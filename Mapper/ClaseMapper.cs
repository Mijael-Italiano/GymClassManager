using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data.SqlClient;

namespace Mapper
{
    public static class ClaseMapper
    {
        public static Clase Map(SqlDataReader reader, Disciplina disciplina)
        {
            return new Clase
            {
                Id_Clase = Convert.ToInt32(reader["Id_Clase"]),
                Disciplina = disciplina,
                Cantidad_Inscriptos = Convert.ToInt32(reader["Cantidad_Inscriptos"]),
                CuotaMensual = Convert.ToInt32(reader["CuotaMensual"].ToString()),
                Maximo_Alumnos = Convert.ToInt32(reader["Maximo_Inscriptos"])
            };
        }
    }
}
