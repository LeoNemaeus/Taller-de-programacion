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
        private bool resultado = false;

        private static List<Partida> listaPartidas = new List<Partida>();
        
        public Partida(DateTime pFI, DateTime pFF, string pNombre, string pPalabra, bool pResultado)
        {
            fechaInicio = pFI;
            fechaFin = pFF;
            nombreJugador = pNombre;
            palabra = pPalabra;
            resultado = pResultado;

            listaPartidas.Add(this);
        }
    }
}
