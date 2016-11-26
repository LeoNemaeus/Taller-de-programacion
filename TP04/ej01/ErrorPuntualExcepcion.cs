using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej01
{
    public class ErrorPuntualExcepcion : ApplicationException
    {
        DateTime iFecha;
        public ErrorPuntualExcepcion()
            {
                iFecha = DateTime.Now;
            }

            public ErrorPuntualExcepcion(string message)
                : base(message)
            {
                iFecha = DateTime.Now;
            }

            public ErrorPuntualExcepcion(string message, ApplicationException inner)
                : base(message, inner)
            {
                iFecha = DateTime.Now;
            }
            public DateTime Fecha
            {
                get { return iFecha;}
            }
    }
}
