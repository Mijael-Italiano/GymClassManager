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
    public class ClaseData
    {
        DisciplinaData disciplinaData = new DisciplinaData();
        public List<Clase> ObtenerClases()
        {
            try
            {
                List<Clase> clases = new List<Clase>();

                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Gimnasio"].ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT Id_Clase, Cantidad_Inscriptos, CuotaMensual, Id_Disciplina, Maximo_Inscriptos FROM Clases";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int idDisciplina = Convert.ToInt32(reader["Id_Disciplina"]);
                                Disciplina disciplina = disciplinaData.GetDisciplinaById(idDisciplina);
                                clases.Add(ClaseMapper.Map(reader, disciplina));
                            }
                        }
                    }
                }

                return clases;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public Clase GetClaseById(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Gimnasio"].ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Clases WHERE Id_Clase = @Id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int idDisciplina = Convert.ToInt32(reader["Id_Disciplina"]);
                                Disciplina disciplina = disciplinaData.GetDisciplinaById(idDisciplina);
                                return ClaseMapper.Map(reader, disciplina);
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

        public Clase GetClaseById(int id, SqlConnection connection)
        {
            try
            {
                string query = "SELECT * FROM Clases WHERE Id_Clase = @Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idDisciplina = Convert.ToInt32(reader["Id_Disciplina"]);
                            Disciplina disciplina = disciplinaData.GetDisciplinaById(idDisciplina, connection);
                            return ClaseMapper.Map(reader, disciplina);
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
        public void DeleteById(int idClase)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Gimnasio"].ConnectionString))
            {
                string query = "DELETE FROM Clases WHERE Id_Clase = @IdClase";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdClase", idClase);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void IncrementarCantidadInscriptos(int idClase)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Gimnasio"].ConnectionString))
            {
                connection.Open();
                string query = "UPDATE Clases SET Cantidad_Inscriptos = Cantidad_Inscriptos + 1 WHERE Id_Clase = @IdClase";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdClase", idClase);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Modificar(Clase clase)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Gimnasio"].ConnectionString))
            {
                string query = "UPDATE Clases SET CuotaMensual = @Cuota, Maximo_Inscriptos = @Maximo WHERE Id_Clase = @IdClase";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Cuota", clase.CuotaMensual);
                    command.Parameters.AddWithValue("@Maximo", clase.Maximo_Alumnos);
                    command.Parameters.AddWithValue("@IdClase", clase.Id_Clase);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        public void AgregarClase(Clase clase)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Gimnasio"].ConnectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Clases (Cantidad_Inscriptos, CuotaMensual, Id_Disciplina, Maximo_Inscriptos) " +
                                   "VALUES (@Cantidad, @Cuota, @Disciplina, @Maximo)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Cantidad", clase.Cantidad_Inscriptos);
                        command.Parameters.AddWithValue("@Cuota", clase.CuotaMensual);
                        command.Parameters.AddWithValue("@Disciplina", clase.Disciplina.Id_Disciplina);
                        command.Parameters.AddWithValue("@Maximo", clase.Maximo_Alumnos);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Clase> ObtenerClasesPorDisciplina(int idDisciplina)
        {
            List<Clase> clases = new List<Clase>();

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Gimnasio"].ConnectionString))
            {
                string query = "SELECT * FROM Clases WHERE Id_Disciplina = @IdDisciplina";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdDisciplina", idDisciplina);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["Id_Disciplina"]);
                            Disciplina disciplina = new DisciplinaData().GetDisciplinaById(id);
                            clases.Add(ClaseMapper.Map(reader, disciplina));
                        }
                    }
                }
            }

            return clases;
        }



        public void DecrementarCantidadInscriptos(int idClase)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Gimnasio"].ConnectionString))
            {
                connection.Open();
                string query = "UPDATE Clases SET Cantidad_Inscriptos = Cantidad_Inscriptos - 1 WHERE Id_Clase = @IdClase";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdClase", idClase);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
