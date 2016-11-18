using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TODO  excepciones
//UNDONE implementar, documentar, testear
namespace ej07.patron_filter
{
    //Criterio compuesto OR
    //Será la raíz en un árbol de criterios.
    public class CriterioOr : ICriterio
    {
        private ICriterio iUnCriterio, iOtroCriterio;

        public CriterioOr() { }
        public CriterioOr(ICriterio pUnCriterio)
        {
            this.iUnCriterio = pUnCriterio;
        }
        public CriterioOr(ICriterio pUnCriterio, ICriterio pOtroCriterio)
        {
            this.iUnCriterio = pUnCriterio;
            this.iOtroCriterio = pOtroCriterio;
        }
        

        /// <summary>
        /// Valida que un Evento cumpla al menos uno de dos Criterios dados.
        /// </summary>
        /// <param name="pEvento"></param>
        /// <returns></returns>
        public bool cumpleCriterio(Evento pEvento)
        {
            return (this.iUnCriterio.cumpleCriterio(pEvento) ||
                (this.iOtroCriterio.cumpleCriterio(pEvento)));
        }
    }
}
