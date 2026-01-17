using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Entity
{
    public class Clase
    {
        public int Id_Clase { get; set; }
        public Disciplina Disciplina { get; set; }
        public int Cantidad_Inscriptos { get; set; }
        public int CuotaMensual { get; set; }
        public int Maximo_Alumnos { get; set; }
    }
}
