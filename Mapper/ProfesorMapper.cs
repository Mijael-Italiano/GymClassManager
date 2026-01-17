using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data.SqlClient;

namespace Mapper
{
    public class ProfesorMapper
    {
        public static Profesor Map(SqlDataReader reader, Disciplina disciplina)
        {
            return new Profesor
            {
                ID_Profesor = Convert.ToInt32(reader["ID_Profesor"]),
                Nombre = reader["Nombre"].ToString(),
                Apellido = reader["Apellido"].ToString(),
                Sueldo = Convert.ToInt32(reader["Sueldo"]),
                DNI = Convert.ToInt32(reader["DNI"]),
                Disciplina = disciplina
            };
        }

    }
}
