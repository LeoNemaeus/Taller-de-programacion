using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej04
{
    class Fachada
    {
        public static FabricaEncriptadores instanciar()
        {
            return FabricaEncriptadores.Instancia;
        }
    }
}
