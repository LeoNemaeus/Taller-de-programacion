using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej04
{
    interface IEncriptador
    {
        public string Encriptar(string pCadena);
        public string Desencriptar(string pCadena);
    }
}
