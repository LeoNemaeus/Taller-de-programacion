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
        private static bool resultadoActual =false; // 0 perder, 1 ganar

        private static void nuevaPalabra()
        {
            string[] palabras =
            {
                "TATO", "PATRIARCADO", "DARKS", "PYTHON", "BULBASAUR",
                "PENTAKILL", "INICIATIVA", "YGGDRASIL", "KATARINA", "IRACUNDO",
                "CONDENSADOR", "DILDO", "LICUADO", "TESERACTO", "JASPE",
                "POLONIA", "CINNAMON", "KILOBYTE", "IBUEVANOL", "ARENA",
                "TROLL", "MUFFIN", "STRIPPER", "SEMICORCHEA", "ELOCUENCIA",
                "GARRAPIÑADA", "LGBT", "VELOCIRAPTOR", "YOUTUBER", "MONTICULO"
            };
            palabraActual = palabras[new Random().Next(0, 30)];
        }

        public static void iniciarPartida(string pNombreJugador, int pIntentos)
        {
            nuevaPalabra();
            nombreJugadorActual = pNombreJugador;
            intentosActuales = pIntentos;
            fechaInicioActual = DateTime.Now;
            // TODO: hacer aqui el juego en si, resultado false?

            fechaFinActual = DateTime.Now;

            guardarPartida();
        }

        private static void guardarPartida()
        {
            new Partida(fechaInicioActual, 
                fechaFinActual, 
                nombreJugadorActual, 
                palabraActual, 
                resultadoActual);
        }

        public static int Intentos
        {
            get { return intentosActuales; }
        }

    }
}
