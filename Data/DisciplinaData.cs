using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using Entity;
using Mapper;

namespace Data
{
    public class DisciplinaData
    {
        public Disciplina GetDisciplinaById(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Gimnasio"].ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Disciplina WHERE Id_Disciplina = @Id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return DisciplinaMapper.Map(reader);
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

        public Disciplina GetDisciplinaById(int id, SqlConnection connection)
        {
            try
            {
                string query = "SELECT * FROM Disciplina WHERE Id_Disciplina = @Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return DisciplinaMapper.Map(reader);
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Disciplina> ObtenerDisciplinas()
        {
            List<Disciplina> lista = new List<Disciplina>();
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Gimnasio"].ConnectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Disciplina";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(DisciplinaMapper.Map(reader));
                        }
                    }
                }
            }
            return lista;
        }



    }
}
