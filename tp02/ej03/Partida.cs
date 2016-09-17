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
        private string palabra;
        private bool resultado;
        private double duracion;

        private static List<Partida> listaPartidas = new List<Partida>();
        public static List<Partida> ListaPartidas
        {
            get { return listaPartidas; }
        }

        public Partida(DateTime pFI, DateTime pFF, string pNombre, string pPalabra, bool pResultado)
        {
            this.fechaInicio = pFI;
            this.fechaFin = pFF;
            this.nombreJugador = pNombre;
            this.palabra = pPalabra;
            this.resultado = pResultado;
            TimeSpan duracionTS = pFF.Subtract(pFI); ;
            this.duracion = duracionTS.TotalMilliseconds;
            listaPartidas.Add(this);
            listaPartidas.Sort((x, y) => x.duracion.CompareTo(y.duracion));
        }

        public DateTime FechaInicio
        {
            get { return this.fechaInicio; }
        }
        public DateTime FechaFin
        {
            get { return this.fechaFin; }
        }
        public string NombreJugador
        {
            get { return this.nombreJugador; }
        }
        public bool Resultado
        {
            get { return this.resultado; }
        }
        public string Palabra
        {
            get { return this.palabra; }
        }
        public double Duracion
        {
            get { return this.duracion; }
        }

        public static List<Partida> filtrarParaElTop5()
        {
            List<Partida> ret = new List<Partida>();
            int cont = 5;
            int i = 0;
            while ((cont!=0)&&(i<ListaPartidas.Count()))
            {
                if (ListaPartidas[i].resultado==true)
                {
                    ret.Add(ListaPartidas[i]);
                    cont--;
                }
                i++;
            }
            return ret;
        }
    }
}
