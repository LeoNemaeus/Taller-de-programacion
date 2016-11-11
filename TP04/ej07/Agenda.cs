using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TODO comentar Agenda
//DOING definir métodos de Agenda
namespace ej07
{
    class Agenda
    {
        private IDictionary<String, Calendario> iCalendarios = new SortedDictionary<String, Calendario>();

        public Agenda() { }

        public void agregarCalendario(string pNombre)
        {
            Calendario mCalendario = new Calendario(pNombre);
            iCalendarios.Add(pNombre, mCalendario);
        }

        public void actualizarCalendario(Calendario pCalendario)
        {
            iCalendarios[pCalendario.Nombre] = pCalendario;
        }

        public void eliminarCalendario(string pNombreCalendario)
        {
            iCalendarios.Remove(pNombreCalendario);
        }
    }
}
