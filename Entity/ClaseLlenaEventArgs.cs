using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ClaseLlenaEventArgs : EventArgs
    {
        public int IdClase { get; }
        public int IdInscripto { get; }

        public ClaseLlenaEventArgs(int idClase, int idInscripto)
        {
            IdClase = idClase;
            IdInscripto = idInscripto;
        }
    }
}
