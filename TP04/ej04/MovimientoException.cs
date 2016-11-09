using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej04
{
    class MovimientoException : ApplicationException
    {
        public MovimientoException() : base()
        { }

        public MovimientoException(string message) : base(message)
        { }

        public MovimientoException(string message, ApplicationException inner) : base(message, inner)
        { }
    }
}
