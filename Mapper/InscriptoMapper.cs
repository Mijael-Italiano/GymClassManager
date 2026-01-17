using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data.SqlClient;

namespace Mapper
{
    public class InscriptoMapper
    {
        public static Inscripto Map(SqlDataReader reader, Clase clase)
        {
            return new Inscripto
            {
                ID_Inscripto = Convert.ToInt32(reader["ID_Inscripto"]),
                clase = clase,
                Nombre = reader["Nombre"].ToString(),
                Apellido = reader["Apellido"].ToString(),
                DNI = Convert.ToInt32(reader["DNI"])
            };
        }
    }
}
