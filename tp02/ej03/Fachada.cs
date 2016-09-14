using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej03
{
    class Fachada
    {
        public static void configurarIntentos(int pNumeroIntentos)
        {
            PartidaActual.Intentos = pNumeroIntentos;
        }

        public static void PartidaEnCurso(bool valor)
        {
            PartidaActual.PartidaEnCurso(valor);
        }
        public static bool PartidaEnCurso()
        {
            return PartidaActual.PartidaEnCurso();
        }
        public static string PalabraEnCurso
        {
            get { return PartidaActual.PalabraEnCurso; }
        }
        public static string PalabraActual
        {
            get { return PartidaActual.PalabraActual; }
        }
        public static List<char> LetrasAcertadas
        {
            get { return PartidaActual.LetrasAcertadas; }
        }
        public static List<char> LetrasIntentadas
        {
            get { return PartidaActual.LetrasIntentadas; }
        }
        public static void verificarLetra(char unaLetra)
        {
            PartidaActual.verificarLetra(unaLetra);
        }
        public static void nuevaPartida(string nombreJugador)
        {
            PartidaActual.iniciarPartida(nombreJugador, PartidaActual.Intentos);
            
            // TODO: hacer atomico
        }

        public static List<PartidaMuestra> top5()
        {
            List<PartidaMuestra> top5 = new List<PartidaMuestra>();//TODO: hacer para lista nula
            List<Partida> partidas = Partida.ListaPartidas;
            Partida iPartida;
            for (int i=0; i<=4; i++)
            {
                iPartida = Partida.ListaPartidas[i];
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
