using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TODO documentar
//UNDONE propiedades
namespace ej07
{
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
