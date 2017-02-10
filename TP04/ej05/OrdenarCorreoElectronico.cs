using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej05
{

    /// <summary>
    /// Clase que ordena los nombres de un usuario alfabéticamente. 
    /// Es herencia de la intefaz <c>IComparer</c> que mantiene el método <c>Compare</c>.
    /// </summary>
    public class OrdenarCorreoElectronico : IComparer<Usuario>
    {
        public int Compare(Usuario x, Usuario y)
        {
            return (x.CorreoElectronico.CompareTo(y.CorreoElectronico));
        }
    }
}
