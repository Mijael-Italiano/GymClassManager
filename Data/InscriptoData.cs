using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data.SqlClient;
using System.Configuration;
using Mapper;

namespace Data
{
    public class InscriptoData
    {
        ClaseData claseData = new ClaseData();
        public List<Inscripto> ObtenerInscriptos()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Gimnasio"].ConnectionString))
                {
                    using (connection)
                    {
                        connection.Open();
                        string query = "SELECT * FROM Inscriptos";
                        SqlCommand command = new SqlCommand(query, connection);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            List<Inscripto> lista = new List<Inscripto>();
                            while (reader.Read())
                            {
                                Clase clase = reader["ID_Clase"] == DBNull.Value
                                    ? null
                                    : claseData.GetClaseById(Convert.ToInt32(reader["ID_Clase"]));

                                lista.Add(InscriptoMapper.Map(reader, clase));
                            }
                            return lista;
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Modificar(Inscripto inscripto)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Gimnasio"].ConnectionString))
            {
                string query = "UPDATE Inscriptos SET Nombre = @Nombre, Apellido = @Apellido, DNI = @DNI WHERE Id_Inscripto = @Id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nombre", inscripto.Nombre);
                    command.Parameters.AddWithValue("@Apellido", inscripto.Apellido);
                    command.Parameters.AddWithValue("@DNI", inscripto.DNI);
                    command.Parameters.AddWithValue("@Id", inscripto.ID_Inscripto);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }


        public List<Inscripto> ObtenerInscriptosPorClase(int? idClase)
        {
            List<Inscripto> lista = new List<Inscripto>();

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Gimnasio"].ConnectionString))
            {
                string query = idClase == null
                    ? "SELECT * FROM Inscriptos WHERE ID_Clase IS NULL"
                    : "SELECT * FROM Inscriptos WHERE ID_Clase = @idClase";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (idClase != null)
                    {
                        command.Parameters.AddWithValue("@idClase", idClase);
                    }

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Clase clase = null;
                            if (!(reader["ID_Clase"] is DBNull))
                            {
                                int id = Convert.ToInt32(reader["ID_Clase"]);
                                clase = new ClaseData().GetClaseById(id);
                            }

                            lista.Add(InscriptoMapper.Map(reader, clase));
                        }
                    }
                }
            }

            return lista;
        }

        public Inscripto GetInscriptoById(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Gimnasio"].ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Inscriptos WHERE ID_Inscripto = @Id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Clase clase = reader["ID_Clase"] == DBNull.Value
                                    ? null
                                    : claseData.GetClaseById(Convert.ToInt32(reader["ID_Clase"]));

                                return InscriptoMapper.Map(reader, clase);
                            }
                            else
                            {
                                return null;
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void QuitarReferenciaClase(int idClase)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Gimnasio"].ConnectionString))
            {
                string query = "UPDATE Inscriptos SET Id_Clase = NULL WHERE Id_Clase = @IdClase";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdClase", idClase);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void AddInscripto(Inscripto inscripto)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Gimnasio"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO INSCRIPTOS (NOMBRE, APELLIDO, DNI) VALUES(@Nombre, @Apellido, @DNI)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nombre", inscripto.Nombre);
                        command.Parameters.AddWithValue("@Apellido", inscripto.Apellido);
                        command.Parameters.AddWithValue("@DNI", inscripto.DNI);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        public void DeleteById(int idInscripto)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Gimnasio"].ConnectionString))
                {
                    conexion.Open();

                    string query = "DELETE FROM INSCRIPTOS WHERE ID_INSCRIPTO = @id";
                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        command.Parameters.AddWithValue("@id", idInscripto);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int? GetIdClaseDeInscripto(int idInscripto)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Gimnasio"].ConnectionString))
            {
                connection.Open();
                string query = "SELECT ID_Clase FROM Inscriptos WHERE ID_Inscripto = @Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", idInscripto);
                    object result = command.ExecuteScalar();
                    return result == DBNull.Value ? (int?)null : Convert.ToInt32(result);
                }
            }
        }

        public void AsociarClase(int idInscripto, int idClase)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Gimnasio"].ConnectionString))
            {
                connection.Open();
                string query = "UPDATE Inscriptos SET ID_Clase = @IdClase WHERE ID_Inscripto = @IdInscripto";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdClase", idClase);
                    command.Parameters.AddWithValue("@IdInscripto", idInscripto);
                    command.ExecuteNonQuery();
                }
            }
        }

        public Inscripto GetInscriptoByDNI(int dni)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Gimnasio"].ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Inscriptos WHERE DNI = @dni";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@dni", dni);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Clase clase = reader["ID_Clase"] == DBNull.Value
                                    ? null
                                    : claseData.GetClaseById(Convert.ToInt32(reader["ID_Clase"]), connection);

                                return InscriptoMapper.Map(reader, clase);
                            }
                        }
                    }
                }
                return null;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
