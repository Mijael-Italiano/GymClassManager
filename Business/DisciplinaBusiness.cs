using Data;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Business
{
    public class DisciplinaBusiness
    {
        private DisciplinaData disciplinaData = new DisciplinaData();

        public List<Disciplina> ObtenerDisciplinas()
        {
            return disciplinaData.ObtenerDisciplinas();
        }
    }
}
