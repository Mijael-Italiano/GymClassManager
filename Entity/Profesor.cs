using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Profesor
    {
        public int ID_Profesor { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Sueldo { get; set; }
        public Disciplina Disciplina { get; set; }
        public int DNI { get; set; }
    }
}
