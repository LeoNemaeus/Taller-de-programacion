using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//TODO excepciones, documentar
//UNDONE métodos,
namespace ej07
{
    class Calendario
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

        public IList<Evento> obtenerEventos() { } //TODO cómo determinar el criterio?
    }
}
