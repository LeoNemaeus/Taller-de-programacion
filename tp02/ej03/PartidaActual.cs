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
        private static string palabraEnCurso;
        private static List<char> letrasIntentadas = new List<char>();
        private static List<char> letrasAcertadas = new List<char>();
        private static bool resultadoActual =false; // 0 perder, 1 ganar
        private static bool partidaEnCurso = false;


        public static string PalabraActual 
        {
            get { return palabraActual; }
        }
        public static string PalabraEnCurso
        {
            get { return palabraEnCurso; }
            set { palabraEnCurso = PalabraEnCurso; }
        }
        public static List<char> LetrasIntentadas
        {
            get { return letrasIntentadas; }
        }
        public static List<char> LetrasAcertadas
        {
            get { return letrasAcertadas; }
        }
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
            palabraEnCurso = "";
            for (int i=1; i<=palabraActual.Length; i++)
            {
                palabraEnCurso += "_";
            }
        }

        public static bool PartidaEnCurso()
        {
            return partidaEnCurso;
        }
        public static void PartidaEnCurso(bool valor)
        {
            partidaEnCurso = valor;
        }
        public static void verificarLetra(char unaLetra)
        {
            bool fallo = false;
            for (int i=0; i<(palabraActual.Length); i++)
            {
                if (palabraActual[i]==unaLetra)
                {
                    string prefijo="", sufijo = "";
                    letrasAcertadas.Add(unaLetra);
                    
                    for (int j=0; j<i; j++)
                    {
                        prefijo += palabraActual[j];
                    }
                    for (int k = i+1; k < palabraActual.Length; k++)
                    {
                        sufijo += palabraActual[k];
                    }
                    palabraEnCurso = prefijo + palabraActual[i] + sufijo;
                }
                else
                {
                    fallo = true;
                }
                if (fallo)
                {
                    intentosActuales--;
                }
            }
        }
        public static void iniciarPartida(string pNombreJugador, int pIntentos)
        {
            nuevaPalabra();
            nombreJugadorActual = pNombreJugador;
            intentosActuales = pIntentos;
            partidaEnCurso = true;
            fechaInicioActual = DateTime.Now;
            letrasIntentadas = new List<char>();
            letrasAcertadas = new List<char>();
            // TODO: hacer aqui el juego en si
            /*
            fechaFinActual = DateTime.Now;

            guardarPartida();*/
        }
        public static void finalizarPartida(bool pResultado)
        {
            fechaFinActual = DateTime.Now;
            partidaEnCurso = false;
            resultadoActual = pResultado;
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
            set { intentosActuales = Intentos; }
        }

    }
}
