using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TODO documentar, excepciones, testear
//DOING implementar, 
namespace ej07.patrón_filter
{
    /// <summary>
    /// Permite determinar si un Evento tiene un nombre determinado.
    /// </summary>
    public class CriterioNombre : ICriterio
    {
        string iNombre;

        public CriterioNombre(string pNombre)
        {
            this.iNombre = pNombre;
        }

        /// <summary>
        /// Verifica que un Evento tenga el nombre definido en el criterio.
        /// </summary>
        /// <param name="pEvento">Un Evento</param>
        /// <returns>Verdadero si cumple el criterio, falso sino.</returns>
        public bool cumpleCriterio(Evento pEvento)
        {
            return (this.iNombre == pEvento.Nombre);
        }
    }
}
