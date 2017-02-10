using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej05
{
    /// <summary>
    /// Clase que lanza una excepcion si el usuario existe
    /// </summary>
    class ExcepcionUsuarioExistente : ApplicationException
    {
        public ExcepcionUsuarioExistente(string message) : base(message) { }
    }
}
