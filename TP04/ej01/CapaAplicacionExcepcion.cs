using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej01
{
    public class CapaAplicacionExcepcion : ApplicationException
    {
            public CapaAplicacionExcepcion()
            {
            }

            public CapaAplicacionExcepcion(string message)
                : base(message)
            {
            }

            public CapaAplicacionExcepcion(string message, ApplicationException inner)
                : base(message, inner)
            {
            }

        }
    }

