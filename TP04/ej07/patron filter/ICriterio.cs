using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TODO documentar
namespace ej07.patrón_filter
{
    public interface ICriterio
    {
        /// <summary>
        /// Permite determinar si un Evento cumple con un criterio.
        /// </summary>
        /// <param name="pEvento">Un Evento</param>
        /// <returns></returns>
        bool cumpleCriterio(Evento pEvento);
    }
}
