using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ej07.patron_filter;


//TODO excepciones, 
//UNDONE métodos, documentar
namespace ej07
{
    /// <summary>
    /// Agrupa un conjunto de Eventos y permite manipularlos.
    /// </summary>
    public class Calendario
    {
        string iNombre;
        DateTime iMomentoCreación;
        IDictionary<string, Evento> iEventos = new SortedDictionary<string, Evento>();

        //Constructor
        public Calendario(string pNombre)
        {
            this.iNombre = pNombre;
            this.iMomentoCreación = DateTime.Now;
        }

        //Propiedades
        public string Nombre
        {
            get { return this.iNombre; }
            set { this.iNombre = value; }
        }

        //Métodos (CRUD de eventos)
        public void agregarEvento(Evento mEvento)
        {
            iEventos.Add(mEvento.Nombre, mEvento);
        }

        public void eliminarEvento(string pNombre)
        {
            iEventos.Remove(pNombre);
        }

        public void actualizarEvento(string pNombre, Evento pEvento)
        {
            iEventos[pNombre] = pEvento;
        }

        //TODO hacer que use los criterios del patrón filter.
        public IList<Evento> obtenerEventos(ICriterio pCriterio)
        {
            IList<Evento> mEventos = new List<Evento>();

            foreach (Evento mEvento in iEventos.Values)
            {
                if (pCriterio.cumpleCriterio(mEvento))
                    mEventos.Add(mEvento);
            }

            return mEventos;
        }
    }
}
