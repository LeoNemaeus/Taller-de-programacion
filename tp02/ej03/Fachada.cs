using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej03
{
    /// <summary cref="Fachada">
    /// <para>Clase del patrón de diseño "Controlador de Fachada",</para>
    /// <para> desacopla la interfaz de usuario del resto del programa.</para>
    /// </summary>
    class Fachada
    {
        /// <summary>
        /// <para>Setea los datos de <see cref="PartidaActual"/> para que se pueda jugar una nueva partida.</para>
        /// <para>Los datos son la hora de inicio, el nombre del jugador y la cantidad de intentos.</para>
        /// <param name="nombreJugador">String que representa el nombre a mostrar del usuario que desea jugar.</param>
        /// </summary>
        public static void nuevaPartida(string nombreJugador)
        {
            PartidaActual.iniciarPartida(nombreJugador);
        }

        /// <summary>
        /// <para>Accesor a la palabra en curso.</para>
        /// <returns>Retorna un String equivalente a la estructura de las letras adivinadas y que faltan adivinar.</returns>
        /// </summary>
        public static string PalabraEnCurso
        {
            get { return PartidaActual.PalabraEnCurso; }
        }

        /// <summary>
        /// <para>Accesor a la palabra actual.</para>
        /// </summary>
        /// <return>Retorna un String equivalente a la palabra elegida aleatoriamente 
        /// al inicio de la partida en su estado original.</return>
        public static string PalabraActual
        {
            get { return PartidaActual.PalabraActual; }
        }

        /// <summary>
        /// Verifica si la partida esta en curso o no.
        /// </summary>
        /// <returns>Retorna TRUE si está en curso, FALSE si se cumple una condición de fin de partida.</returns>
        public static bool PartidaEnCurso()
        {
            return PartidaActual.PartidaEnCurso();
        }

        /// <summary>
        /// Accesor a la lista de caracteres acertados.
        /// </summary>
        /// <returns>Devuelve una lista de caracteres que representa las letras que se acertaron.</returns>
        public static List<char> LetrasAcertadas
        {
            get { return PartidaActual.LetrasAcertadas; }
        }
        /// <summary>
        /// Accesor a la lista de caracteres intentados, acertados o no.
        /// </summary>
        /// <returns>Devuelve una lista de caracteres que representa las letras ingresadas por teclado.</returns>
        public static List<char> LetrasIntentadas
        {
            get { return PartidaActual.LetrasIntentadas; }
        }

        /// <summary>
        /// Se fija si <paramref name="unaLetra"/> es parte de la palabra a adivinar.
        /// </summary>
        /// <param name="unaLetra">Caracter que representa la letra con la que se intenta adivinar.</param>
        public static void verificarLetra(char unaLetra)
        {
            PartidaActual.verificarLetra(unaLetra);
        }

        /// <summary>
        /// Verifica el resultado final de la partida.
        /// </summary>
        /// <returns>Retorna TRUE si fue una victoria, o FALSE si fue una derrota.</returns>
        public static bool verificarResultado()
        {
            if (PartidaActual.victoria())
            {
                return true;
            }
            else { return false; }
        }

        /// <summary>
        /// <para>Setea los datos de fin de partida, como son la hora y el resultado.</para>
        /// <para>Además crea un objeto de clase Partida con los datos especificados.</para>
        /// </summary>
        public static void finalizarPartida()
        {
            PartidaActual.finalizarPartida();
        }

        /// <summary>
        /// Propiedad que setea y obtiene un int equivalente a la cantidad de intentos que tiene
        /// el jugador al inicio de la partida antes de perder. Predeterminados: "10" (diez).
        /// </summary>
        public static int IntentosIniciales
        {
            set { PartidaActual.IntentosIniciales = value; }
            get { return PartidaActual.IntentosIniciales; }
        }

        /// <summary>
        /// Obtiene un int equivalene a los intentos restantes 
        /// </summary>
        public static int IntentosRestantes
        {
            get { return PartidaActual.IntentosActuales; }
        }
        
        
        public static List<PartidaMuestra> top5()
        {
            List<PartidaMuestra> top5 = new List<PartidaMuestra>();
            List<Partida> partidas = Partida.filtrarParaElTop5();
            int cant = partidas.Count();
            if (cant>5) { cant = 5; }
            Partida iPartida;
            for (int i=0; i<=cant-1; i++)
            {
                iPartida = partidas[i];
                PartidaMuestra iPartidaMuestra = new PartidaMuestra(iPartida.NombreJugador,
                    iPartida.Palabra,
                    iPartida.Resultado,
                    iPartida.FechaInicio,
                    iPartida.Duracion);
                top5.Add(iPartidaMuestra);
            }
            return top5;
        }
    }
}
