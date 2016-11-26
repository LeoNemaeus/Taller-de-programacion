using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ej04;

namespace Ej05
{
    public class EncriptadorInverso : Encriptador
    {

        public EncriptadorInverso() : base("Inverso") { }

        public override string Encriptar(string pCadena)

        {
            char[] array = pCadena.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }

        public override string Desencriptar(string pCadena)
            
        {
            char[] array = pCadena.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
    }

}
