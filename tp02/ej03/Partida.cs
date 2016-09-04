using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej03
{
    class Partida
    {
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private string nombreJugador;
        private int intentos;
        private string palabra;
        private bool resultado = false;

        private Partida()
        {
            /*this.fechaInicio
            this.fechaFin
            this.nombreJugador
            this.palabra
            this.intentos
            this.resultado*/
        }

        public void nuevaPartida(int pIntentos)
        {
            //intentosActuales = pIntentos;

        }

        public void configurarIntentos(int pIntentos)
        {
            //intentosActuales = pIntentos;
        }
    }
}
