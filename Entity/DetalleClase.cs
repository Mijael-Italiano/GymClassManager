using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class DetalleClase
    {
        public int Id_Detalle_Clases { get; set; }
        public string Dia { get; set; }
        public TimeSpan Horario_Inicio { get; set; }
        public TimeSpan Horario_Fin { get; set; }

        public Profesor? profesor { get; set; }
        public Clase? clase { get; set; }

    }
}
