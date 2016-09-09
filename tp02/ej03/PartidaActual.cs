using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej03
{
    class PartidaActual
    {
        private static DateTime fechaInicioActual;
        private static DateTime fechaFinActual;
        private static string nombreJugadorActual;
        private static int intentosActuales;
        private static string palabraActual;
        private static bool resultadoActual; // 0 perder, 1 ganar

        // TODO: hacer el aleatorio y el string
        private static void nuevaPalabra()
        {
            palabraActual = "asado";
        }

        public Partida iniciarPartida(string pNombreJugador, int pIntentos)
        {
            nuevaPalabra();
            nombreJugadorActual = pNombreJugador;
            intentosActuales = pIntentos;
            fechaInicioActual = DateTime.Now;
            // TODO: hacer aqui el juego en si

            fechaFinActual = DateTime.Now;

            guardarPartida();
            return new Partida();
        }

        private void guardarPartida()
        {
            // TODO: guardar partidas
        }
    }
}
