using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TODO  excepciones
//UNDONE implementar, documentar, testear
namespace ej07.patrón_filter
{
    //Criterio compuesto OR
    public class CriterioOr : ICriterio
    {
        private ICriterio iUnCriterio, iOtroCriterio;
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
