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
    public class ProfesorData
    {
        DisciplinaData disciplinaData = new DisciplinaData();
        public List<Profesor> ObtenerProfesores()
        {

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Gimnasio"].ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Profesores";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            List<Profesor> lista = new List<Profesor>();
                            while (reader.Read())
                            {
                                int idDisciplina = Convert.ToInt32(reader["Id_Disciplina"]);
                                Disciplina disciplina = disciplinaData.GetDisciplinaById(idDisciplina);
                                lista.Add(ProfesorMapper.Map(reader, disciplina));
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

        public void AgregarProfesor(Profesor profesor)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Gimnasio"].ConnectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Profesores (Nombre, Apellido, DNI, Id_Disciplina, Sueldo) " +
                                   "VALUES (@Nombre, @Apellido, @DNI, @Disciplina, @Sueldo)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nombre", profesor.Nombre);
                        command.Parameters.AddWithValue("@Apellido", profesor.Apellido);
                        command.Parameters.AddWithValue("@DNI", profesor.DNI);
                        command.Parameters.AddWithValue("@Disciplina", profesor.Disciplina.Id_Disciplina);
                        command.Parameters.AddWithValue("@Sueldo", profesor.Sueldo);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Profesor GetProfesorById(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Gimnasio"].ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Profesores WHERE ID_Profesor = @Id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int idDisciplina = Convert.ToInt32(reader["Id_Disciplina"]);
                                Disciplina disciplina = disciplinaData.GetDisciplinaById(idDisciplina);
                                return ProfesorMapper.Map(reader, disciplina);
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




        public void Modificar(Profesor profesor)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Gimnasio"].ConnectionString))
            {
                string query = "UPDATE Profesores SET Nombre = @Nombre, Apellido = @Apellido, DNI = @DNI, Sueldo = @Sueldo WHERE ID_Profesor = @Id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nombre", profesor.Nombre);
                    command.Parameters.AddWithValue("@Apellido", profesor.Apellido);
                    command.Parameters.AddWithValue("@DNI", profesor.DNI);
                    command.Parameters.AddWithValue("@Sueldo", profesor.Sueldo);
                    command.Parameters.AddWithValue("@Id", profesor.ID_Profesor);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        public void DeleteById(int idProfesor)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Gimnasio"].ConnectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM Profesores WHERE ID_Profesor = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", idProfesor);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el profesor", ex);
            }
        }


        public List<Profesor> ObtenerProfesoresPorDisciplina(int idDisciplina)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Gimnasio"].ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Profesores WHERE Id_Disciplina = @IdDisciplina";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdDisciplina", idDisciplina);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            List<Profesor> lista = new List<Profesor>();
                            while (reader.Read())
                            {
                                int idDisc = Convert.ToInt32(reader["Id_Disciplina"]);
                                Disciplina disciplina = disciplinaData.GetDisciplinaById(idDisc);
                                lista.Add(ProfesorMapper.Map(reader, disciplina));
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

        public Profesor getProfesorByDNI(int dni)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Gimnasio"].ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Profesores WHERE DNI = @dni";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@dni", dni);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int idDisciplina = Convert.ToInt32(reader["Id_Disciplina"]);
                                Disciplina disciplina = disciplinaData.GetDisciplinaById(idDisciplina, connection);
                                return ProfesorMapper.Map(reader, disciplina);
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
