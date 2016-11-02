using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej05
{
    public abstract class Encriptador : IEncriptador
    {
        private String iNombre;

        public Encriptador(String pNombre)
        {
            this.iNombre = pNombre;
        }

        public String Nombre
        {
            get { return this.iNombre; }
        }
       
        public abstract String Encriptar(String pCadena);
        
        public abstract String Desencriptar(String pCadena);
    }
}
