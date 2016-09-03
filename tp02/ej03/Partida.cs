using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej03
{
    class Partida
    {
        private static DateTime fechaInicioActual;
        private static DateTime fechaFinActual;
        private static string nombreJugadorActual;
        private static int intentosActuales;
        private static string palabraActual;
        private static bool resultadoActual;

        private DateTime fechaInicio;
        private DateTime fechaFin;
        private string nombreJugador;
        private int intentos;
        private string palabra;
        private bool resultado = false;

        private Partida()
        {
            this.fechaInicio = fechaInicioActual;
            this.fechaFin = fechaFinActual;
            this.nombreJugador = nombreJugadorActual;
            this.palabra = palabraActual;
            this.intentos = intentosActuales;
            this.resultado = resultadoActual;
        }

        public void nuevaPartida(int pIntentos)
        {
            intentosActuales = pIntentos;

        }
    }
}
