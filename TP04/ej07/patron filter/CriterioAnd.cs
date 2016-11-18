using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TODO excepciones, testear
//UNDONE implementar,documentar, 
namespace ej07.patron_filter
{
    /// <summary>
    /// Criterio compuesto AND. Determina si se cumplen dos criterios dados.
    /// </summary>
    public class CriterioAnd : ICriterio
    {
        ICriterio iUnCriterio, iOtroCriterio;
        public CriterioAnd(ICriterio pUnCriterio, ICriterio pOtroCriterio)
        {
            this.iUnCriterio = pUnCriterio;
            this.iOtroCriterio = pOtroCriterio;
        }

        /// <summary>
        /// Valida que se cumplan ambos criterios dados.
        /// </summary>
        /// <param name="pEvento">Un Evento</param>
        /// <returns>Verdadero si se cumplen ambos criterios, falso sino.</returns>
        public bool cumpleCriterio(Evento pEvento)
        {
            return (this.iUnCriterio.cumpleCriterio(pEvento) && this.iOtroCriterio.cumpleCriterio(pEvento));
        }
    }
}
