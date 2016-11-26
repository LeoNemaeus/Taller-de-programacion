using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej04
{
    // implementa IEncriptador
    public class Encriptador : IEncriptador
    {
        private string iNombre;

        public Encriptador(string pNombre)
        {
            iNombre = pNombre;
            //TODO: que va aca?
        }
        public string Nombre
        {
            get { return iNombre; }
            set { iNombre = value; }
        }

        // las que se van a heredar
        public virtual string Encriptar(string pCadena)
        {
            return pCadena;
        }
        public virtual string Desencriptar(string pCadena)
        {
            return pCadena;
        }
    }
}
