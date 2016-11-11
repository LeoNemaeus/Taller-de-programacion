using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TODO uncrappear, documentar
//UNDONE propiedades
namespace ej07
{
    /// <summary>
    /// Un Evento de un calendario.
    /// Las repeticiones se calculan en el service del evento
    /// </summary>
    public class Evento
    {
        private string iNombre;
        private DateTime iComienzo;
        private TimeSpan iDuracion;
        private Frecuencia iFrecuencia;

        public Evento(string pNombre, DateTime pComienzo, TimeSpan pDuracion, Frecuencia pFrecuencia)
        {
            this.iNombre = pNombre;
            this.iComienzo = pComienzo;
            this.iDuracion = pDuracion;
            this.iFrecuencia = pFrecuencia;
        }

        //Propiedades
        public string Nombre
        {
            get { return this.iNombre; }
        }

        public DateTime Comienzo
        {
            get { return this.iComienzo; }
        }

        public TimeSpan Duracion
        {
            get { return this.iDuracion; }
        }

        public Frecuencia Frecuencia
        {
            get { return this.iFrecuencia; }
        }
    }
}
