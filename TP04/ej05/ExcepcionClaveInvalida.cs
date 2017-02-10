using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej05
{
    /// <summary>
    /// Clase que lanza una excepcion si la clave no existe
    /// </summary>
    public class ExcepcionClaveInvalida : ApplicationException
    {
        public ExcepcionClaveInvalida(string message) : base(message) { }
    }
}
