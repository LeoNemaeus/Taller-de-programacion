using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// zi
namespace ej03
{
    /// <summary>
    /// Clase Modelo del MVC, para la clase Partida. Para que la Interfaz de usuario interactúe.
    /// </summary>
    class PartidaMuestra
    {
        private string nombreJugador;
        private string palabra;
        private bool resultado;
        private DateTime fechaInicio;
        private double duracion;
        public PartidaMuestra(string pNombreJugador, string pPalabra, bool pResultado, DateTime pFI, double pDuracion)
        {
            this.nombreJugador = pNombreJugador;
            this.palabra = pPalabra;
            this.resultado = pResultado;
            this.fechaInicio = pFI;
            this.duracion = pDuracion;
        }
        public DateTime FechaInicio
        {
            get { return this.fechaInicio; }
        }
        public string NombreJugador
        {
            get { return this.nombreJugador; }
        }
        public bool Resultado
        {
            get { return this.resultado; }
        }
        public string Palabra
        {
            get { return this.palabra; }
        }
        public double Duracion
        {
            get { return this.duracion; }
        }
    }
}
