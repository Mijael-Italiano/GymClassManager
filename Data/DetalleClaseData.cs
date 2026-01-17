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
    public class DetalleClaseData
    {
        ClaseData claseData = new ClaseData();
        ProfesorData profesorData = new ProfesorData();
        public List<DetalleClase> ObtenerDetalleClases()
        {
            try
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Gimnasio"].ConnectionString);
                using (connection)
                {
                    connection.Open();
                    string query = "SELECT * FROM Detalle_Clase";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            List<DetalleClase> lista = new List<DetalleClase>();
                            while (reader.Read())
                            {
                                int idProfesor = Convert.ToInt32(reader["ID_Profesor"]);
                                int idClase = Convert.ToInt32(reader["ID_Clase"]);
                                Profesor profesor = profesorData.GetProfesorById(idProfesor);
                                Clase clase = claseData.GetClaseById(idClase);
                                lista.Add(DetalleClaseMapper.Map(reader, profesor, clase));
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

        public List<DetalleClase> ObtenerDetalleClasesPorProfesor(Profesor profesor)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Gimnasio"].ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Detalle_Clase WHERE ID_Profesor = @IdProfesor";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdProfesor", profesor.ID_Profesor);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            List<DetalleClase> lista = new List<DetalleClase>();

                            while (reader.Read())
                            {
                                int idClase = Convert.ToInt32(reader["ID_Clase"]);
                                Clase clase = claseData.GetClaseById(idClase);

                                DetalleClase detalle = DetalleClaseMapper.Map(reader, profesor, clase);
                                lista.Add(detalle);
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


        public void DeleteById(int id)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Gimnasio"].ConnectionString))
                {
                    conexion.Open();
                    string query = "DELETE FROM Detalle_Clase WHERE ID_Detalle_Clases = @id";
                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Agregar(DetalleClase detalle)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Gimnasio"].ConnectionString))
                {
                    connection.Open();

                    string query = @"INSERT INTO Detalle_Clase (Dia, Horario_Inicio, Horario_Fin, ID_Profesor, ID_Clase)
                             VALUES (@Dia, @HorarioInicio, @HorarioFin, @IdProfesor, @IdClase)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Dia", detalle.Dia);
                        command.Parameters.AddWithValue("@HorarioInicio", detalle.Horario_Inicio);
                        command.Parameters.AddWithValue("@HorarioFin", detalle.Horario_Fin);
                        command.Parameters.AddWithValue("@IdProfesor", detalle.profesor.ID_Profesor);
                        command.Parameters.AddWithValue("@IdClase", detalle.clase.Id_Clase);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<DetalleClase> ObtenerDetalleClasesPorClase(int idClase)
        {
            try
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Gimnasio"].ConnectionString);
                using (connection)
                {
                    connection.Open();
                    string query = "SELECT * FROM Detalle_Clase WHERE ID_Clase = @IdClase";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdClase", idClase);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            List<DetalleClase> lista = new List<DetalleClase>();
                            while (reader.Read())
                            {
                                int? idProfesor = reader["ID_Profesor"] != DBNull.Value
                                    ? Convert.ToInt32(reader["ID_Profesor"])
                                    : (int?)null;
                                int idClaseFromDb = Convert.ToInt32(reader["ID_Clase"]);

                                Profesor profesor = idProfesor.HasValue
                                    ? profesorData.GetProfesorById(idProfesor.Value)
                                    : null;
                                Clase clase = claseData.GetClaseById(idClaseFromDb);

                                lista.Add(DetalleClaseMapper.Map(reader, profesor, clase));
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


        public void EliminarPorClase(int idClase)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Gimnasio"].ConnectionString))
            {
                string query = "DELETE FROM Detalle_Clase WHERE Id_Clase = @IdClase";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdClase", idClase);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }


        public void QuitarReferenciaProfesor(int idProfesor)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Gimnasio"].ConnectionString))
                {
                    connection.Open();
                    string query = "UPDATE Detalle_Clase SET ID_Profesor = NULL WHERE ID_Profesor = @idProfesor";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idProfesor", idProfesor);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al quitar referencia del profesor en Detalle_Clase", ex);
            }
        }


            public DetalleClase GetById(int id)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Gimnasio"].ConnectionString))
                    {
                        connection.Open();
                        string query = "SELECT * FROM Detalle_Clase WHERE ID_Detalle_Clases = @id";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@id", id);

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    Profesor profesor = null;

                                    if (reader["ID_Profesor"] != DBNull.Value)
                                    {
                                        int idProfesor = Convert.ToInt32(reader["ID_Profesor"]);
                                        profesor = profesorData.GetProfesorById(idProfesor);
                                    }  
                                     int idClase = Convert.ToInt32(reader["ID_Clase"]);
                                     Clase clase = claseData.GetClaseById(idClase);
                                     return DetalleClaseMapper.Map(reader, profesor, clase);
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

        public void Modificar(DetalleClase detalle)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Gimnasio"].ConnectionString))
            {
                string query = @"UPDATE Detalle_Clase
                         SET Dia = @Dia,
                             Horario_Inicio = @Inicio,
                             Horario_Fin = @Fin,
                             ID_Profesor = @IdProfesor
                         WHERE ID_Detalle_Clases = @IdDetalle";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Dia", detalle.Dia);
                    command.Parameters.AddWithValue("@Inicio", detalle.Horario_Inicio);
                    command.Parameters.AddWithValue("@Fin", detalle.Horario_Fin);
                    command.Parameters.AddWithValue("@IdProfesor", detalle.profesor.ID_Profesor);
                    command.Parameters.AddWithValue("@IdDetalle", detalle.Id_Detalle_Clases);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
