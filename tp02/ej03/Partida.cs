using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej03
{
    class Partida
    {
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private string nombreJugador;
        private string palabra;
        private bool resultado;
        private double duracion;

        private static List<Partida> listaPartidas = new List<Partida>();
        
        public Partida(DateTime pFI, DateTime pFF, string pNombre, string pPalabra, bool pResultado)
        {
            this.fechaInicio = pFI;
            this.fechaFin = pFF;
            this.nombreJugador = pNombre;
            this.palabra = pPalabra;
            this.resultado = pResultado;
            TimeSpan duracionTS = pFF.Subtract(pFI); ;
            this.duracion = duracionTS.TotalMilliseconds;
            listaPartidas.Add(this);
            listaPartidas.Sort((x, y) => x.duracion.CompareTo(y.duracion));
        }
    }
}
