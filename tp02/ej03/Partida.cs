using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej03
{
    /// <summary>
    /// Clase para guardar las partidas guardadas. Cada instancia es una partida.
    /// </summary>
    class Partida
    {
        private DateTime fechaInicio; //cuando comenzó
        private DateTime fechaFin; // cuando terminó
        private string nombreJugador; // quién jugó
        private string palabra; // cual era la palabra
        private bool resultado; // true si ganó, false si perdió
        private double duracion; // fechaFin - fechaInicio, se guarda por cuestiones de eficiencia

        // atributo de clase que guarda las instancias de la misma.
        private static List<Partida> listaPartidas = new List<Partida>();

        /// <summary>
        /// Property para conseguir la lista de partidas.
        /// </summary>
        public static List<Partida> ListaPartidas
        {
            get { return listaPartidas; }
        }

        /// <summary>
        /// Constructor. Crea el objeto y lo añade a la lista.
        /// </summary>
        /// <param name="pFI">Fecha inicio. DateTime</param>
        /// <param name="pFF">Fecha fin. DateTime</param>
        /// <param name="pNombre">Nombre del jugador. String</param>
        /// <param name="pPalabra">Palabra que se intentaba adivinar. String</param>
        /// <param name="pResultado">Resultado. false derrota, true victoria.</param>
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

        // getters y setters
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

        /// <summary>
        /// Selecciona las 5 (como máximo) partidas victoriosas con la menor duracion.
        /// </summary>
        /// <returns>Devuelve una List<> de Partidas.</returns>
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
