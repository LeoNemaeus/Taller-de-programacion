using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej04
{
    // implementa IEncriptador
    class Encriptador : IEncriptador
    {
        private string iNombre;

        public Encriptador(string pNombre)
        {
        }
        public string Nombre
        {
            get { return iNombre; }
            set { iNombre = value; }
        }

        // las que se van a heredar
        public string Encriptar(string pCadena)
        {
            return pCadena;
        }
        public string Desencriptar(string pCadena)
        {
            return pCadena;
        }
    }
}
