using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej04
{
    class FabricaEncriptadores
    {
        private Dictionary<string,IEncriptador> iEncriptadores;

        private static readonly Lazy<FabricaEncriptadores> cinstancia = new Lazy<FabricaEncriptadores>(() => new FabricaEncriptadores());

        private FabricaEncriptadores() { }

        public static FabricaEncriptadores Instancia
        {
            get { return cinstancia.Value; }
        }


    }
}
 