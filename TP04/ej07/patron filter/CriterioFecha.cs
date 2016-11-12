using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TODO excepciones, testear
//DOING implementar, documentar
namespace ej07.patrón_filter
{
    /// <summary>
    /// Permite determinar si un Evento se encuentra en un rango de fechas.
    /// Si se provee una única fecha, se busca todos los eventos de esa fecha.
    /// </summary>
    public class CriterioFecha : ICriterio
    {
        DateTime iFechaInicio, iFechaFin;
        bool rango = false;
        public CriterioFecha(DateTime pFechaInicio, DateTime pFechaFin)
        {
            this.iFechaInicio = pFechaInicio;
            this.iFechaFin = pFechaFin;
            this.rango = true;
        }

        public CriterioFecha(DateTime pFecha)
        {
            this.iFechaInicio = pFecha;
        }

        /// <summary>
        /// Verifica que un Evento se encuentre en un rango de fechas.
        /// </summary>
        /// <param name="pEvento"></param>
        /// <returns></returns>
        public bool cumpleCriterio(Evento pEvento)
        {
            if (this.rango)
            {
                //El Evento comienza después y termina antes del límite inferior del rango
                return ((this.iFechaInicio.CompareTo(pEvento.Comienzo) <= 0)
                    &&
                    (this.iFechaFin.CompareTo(pEvento.Comienzo) >= 0));

            } else
            {
                return (pEvento.Comienzo == this.iFechaInicio);
            }

        }
    }
}
