using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data.SqlClient;

namespace Mapper
{
    public static class DetalleClaseMapper
    {
        public static DetalleClase Map(SqlDataReader reader, Profesor? profesor, Clase clase)
        {
            return new DetalleClase
            {
                Id_Detalle_Clases = Convert.ToInt32(reader["Id_Detalle_Clases"]),
                Dia = reader["Dia"].ToString(),
                Horario_Inicio = (TimeSpan)reader["Horario_Inicio"],
                Horario_Fin = (TimeSpan)reader["Horario_Fin"],
                profesor = profesor,
                clase = clase
            };
        }
    }
}
