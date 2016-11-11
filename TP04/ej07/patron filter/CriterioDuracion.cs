using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TODO excepciones, testear
//DOING implementar, documentar, 
namespace ej07.patrón_filter
{
    /// <summary>
    /// Permite determinar si un Evento cumple con una duración determinada.
    /// </summary>
    public class CriterioDuracion : ICriterio
    {
        private TimeSpan iDuracion;

        CriterioDuracion(TimeSpan pDuracion)
        {
            this.iDuracion = pDuracion;
        }

        /// <summary>
        /// Verifica que un evento tenga la duración definida por el filtro.
        /// </summary>
        /// <param name="pEvento"></param>
        /// <returns></returns>
        public bool cumpleCriterio(Evento pEvento)
        {
            return (pEvento.Duracion == iDuracion);
        }
    }
}
