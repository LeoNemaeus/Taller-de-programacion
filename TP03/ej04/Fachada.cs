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

            // aca es en donde mas hay que tocar cosas.
            // hay que linkear la interfaz con los metodos de aca y con ENCRIPTAR() y
            // DESENCRIPTAR() de los encriptadores (que se devuelven desde el diccionario)
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
