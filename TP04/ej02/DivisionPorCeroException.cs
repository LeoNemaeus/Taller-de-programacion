using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej02
{
    public class DivisionPorCeroException: Exception
    {
        public DivisionPorCeroException(string pMensaje)
            : base(pMensaje)
        {

        }

        public DivisionPorCeroException()  : base()
        {

        }
    }
}
