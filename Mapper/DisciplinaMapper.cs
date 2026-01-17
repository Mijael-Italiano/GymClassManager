using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data.SqlClient;

namespace Mapper
{
    public class DisciplinaMapper
    {
        public static Disciplina Map(SqlDataReader reader)
        {
            return new Disciplina
            {
                Id_Disciplina = Convert.ToInt32(reader["Id_Disciplina"]),
                Nombre_Disciplina = reader["Nombre_Disciplina"].ToString()
            };
        }
    }
}
