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
            // TODO: hacer configurar intentos
        }

        public static void nuevaPartida(string nombreJugador)
        {
            PartidaActual.iniciarPartida(nombreJugador, PartidaActual.Intentos);
        }

        public static void top5()
        {
            // TODO: hacer top 5
        }
    }
}
