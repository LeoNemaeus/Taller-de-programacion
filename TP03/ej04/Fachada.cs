using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej04
{
    class Fachada
    {
        public static FabricaEncriptadores instanciarFabrica()
        {
            return FabricaEncriptadores.Instancia;
        }

        internal static void Encriptar(string v)
        {
            throw new NotImplementedException();
        }

        internal static void Desencriptar(string v)
        {
            throw new NotImplementedException();
        }
    }
}
