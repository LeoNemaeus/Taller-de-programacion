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
        private static int intentosIniciales;
        private static int intentosActuales;
        private static string palabraActual;
        private static string palabraEnCurso;
        private static List<char> letrasIntentadas = new List<char>();
        private static List<char> letrasAcertadas = new List<char>();
        private static bool resultadoActual = false; // 0 perder, 1 ganar
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
            for (int i = 1; i <= palabraActual.Length; i++)
            {
                palabraEnCurso += "_";
            }
        }

        public static bool PartidaEnCurso()
        {
            if (victoria())
            {
                return false;
            }
            else if (derrota())
            {
                return false;
            }
            else return true;
        }
        public static void PartidaEnCurso(bool valor)
        {
            partidaEnCurso = valor;
        }
        public static void verificarLetra(char unaLetra)
        {
            letrasIntentadas.Add(unaLetra);
            bool fallo = true;
            for (int i = 0; i < (palabraActual.Length); i++)
            {
                if (palabraActual[i] == unaLetra)
                {
                    
                    string prefijo = "", sufijo = "";
                    letrasAcertadas.Add(unaLetra);
                    for (int j = 0; j < i; j++)
                    {
                        prefijo += palabraEnCurso[j];
                    }
                    for (int k = i + 1; k < palabraActual.Length; k++)
                    {
                        sufijo += palabraEnCurso[k];
                    }
                    palabraEnCurso = prefijo + palabraActual[i] + sufijo;

                    if (fallo) { fallo = false; }
                }
            }
            if (fallo)
            {
                intentosActuales = intentosActuales - 1;
            }
        }
        public static void iniciarPartida(string pNombreJugador)
        {
            nuevaPalabra();
            nombreJugadorActual = pNombreJugador;
            intentosActuales = intentosIniciales;
            partidaEnCurso = true;
            fechaInicioActual = DateTime.Now;
            letrasIntentadas = new List<char>();
            letrasAcertadas = new List<char>();
        }
        public static void finalizarPartida()
        {
            fechaFinActual = DateTime.Now;
            partidaEnCurso = false;
            if (victoria())
            {
                resultadoActual = true;
            } else
            {
                resultadoActual = false;
            }
            guardarPartida();
        }
        public static bool derrota()
        {
            if (intentosActuales == 0)
            {
                return true;
            }
            else { return false; }
        }
        public static bool victoria()
        {
            if (palabraActual == palabraEnCurso)
            {
                return true;
            }
            else { return false; }
        }
        private static void guardarPartida()
        {
            new Partida(fechaInicioActual, 
                fechaFinActual, 
                nombreJugadorActual, 
                palabraActual, 
                resultadoActual);
        }

        public static void intentos(int pIntentos)
        {
            intentosIniciales = pIntentos;
        }
        public static int intentos()
        {
            return intentosActuales;
        }

    }
}
