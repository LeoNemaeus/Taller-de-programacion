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

        public static void nuevaPartida(string nombreJugador)
        {
            PartidaActual.iniciarPartida(nombreJugador, PartidaActual.Intentos);
        }

        public static List<PartidaMuestra> top5()
        {
            List<PartidaMuestra> top5 = new List<PartidaMuestra>();
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
