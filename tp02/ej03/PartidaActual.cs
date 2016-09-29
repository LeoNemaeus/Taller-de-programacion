using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej03
{
    class PartidaActual
    {
        // atributos
        private static DateTime fechaInicioActual;
        private static DateTime fechaFinActual;
        private static string nombreJugadorActual;
        private static int intentosIniciales = 10; // se usa al crear la partida, 10 por defecto
        private static int intentosActuales; // se usa durante la partida
        private static string palabraActual; // la palabra que se intenta adivinar
        private static string palabraEnCurso; // estado actual de la palabra
        private static List<char> letrasIntentadas = new List<char>();
        private static List<char> letrasAcertadas = new List<char>();
        private static bool resultadoActual = false; // 0 perder, 1 ganar
        private static bool partidaEnCurso = false; // 0 no partida, 1 si partida

        /// <summary>
        /// getter de palabra Actual, devuelve String.
        /// </summary>
        public static string PalabraActual
        {
            get { return palabraActual; }
        }
        /// <summary>
        /// getter y setter de palabra en curso, devuelve y asigna String.
        /// </summary>
        public static string PalabraEnCurso
        {
            get { return palabraEnCurso; }
            set { palabraEnCurso = value; }
        }

        /// <summary>
        /// Getter de las letras intentadas, devuelve una List de char.
        /// </summary>
        public static List<char> LetrasIntentadas
        {
            get { return letrasIntentadas; }
        }
        /// <summary>
        /// Getter de las letras acertadas, devuelve una List de char.
        /// </summary>
        public static List<char> LetrasAcertadas
        {
            get { return letrasAcertadas; }
        }

        /// <summary>
        /// Selecciona una palabra aleatoria de un array, la guarda en palabraActual, e
        /// inicializa palabraEnCurso como un string de guiones bajos como el largo de la
        /// palabra elegida.
        /// </summary>
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

        /// <summary>
        /// Indica si se esta jugando o no.
        /// </summary>
        /// <returns>Devuelve true si se esta jugando. False si la partida no esta activa.</returns>
        public static bool PartidaEnCurso()
        {
            // al ganar o perder se entiende que la partida termino
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="valor"></param>
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

        public static int IntentosIniciales
        {
            get { return intentosIniciales; }
            set { intentosIniciales = value; }
        }
        public static int IntentosActuales
        {
            get { return intentosActuales; }
            set { intentosActuales = value; }
        }

    }
}
