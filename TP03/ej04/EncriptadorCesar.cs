using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej04
{
    public class EncriptadorCesar : Encriptador
    {
        private int iDesplazamiento;
        // alfabeto, se necesita para el algoritmo del encriptador
        private static string abc = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890_-+,#$%&/()=¿?¡!|,.;:{}[]";
        // metodo interno usado por el encriptador
        private static int getPosABC(char caracter)
        {
            for ( int i = 0; i<abc.Length ; i++)
            {
                if (caracter == abc[i])
                {
                    return i;
                }
            }
            return -1;
        }

        public EncriptadorCesar(int pDesplazamiento) : base("César")
        {
            iDesplazamiento = pDesplazamiento;
        }

        public override string Encriptar(string pCadena)
        {

            int desplazamiento = iDesplazamiento;
            string cifrado = "";
            if (desplazamiento > 0 && desplazamiento < pCadena.Length)
            {
                for (int i = 0; i < pCadena.Length; i++)
                {
                    int posCaracter = getPosABC(pCadena[i]);
                    if (posCaracter != -1) //el caracter existe en la variable abc
                    {
                        int pos = posCaracter + desplazamiento;
                        while (pos >= abc.Length)
                        {
                            pos = pos - abc.Length;
                        }
                        //concatena al mensaje cifrado
                        cifrado += abc[pos];
                    }
                    else//si no existe el caracter no se cifra
                    {
                        cifrado += pCadena[i];
                    }
                }
            }
            return cifrado;
        }


        public override string Desencriptar(string pCadena)
        {
            String cifrado = "";
            if (iDesplazamiento > 0 && iDesplazamiento < abc.Length)
            {
                for (int i = 0; i < pCadena.Length; i++)
                {
                    int posCaracter = getPosABC(pCadena[i]);
                    if (posCaracter != -1) //el caracter existe en la variable abc
                    {
                        int pos = posCaracter - iDesplazamiento;
                        while (pos < 0)
                        {
                            pos = pos + abc.Length;
                        }
                        cifrado += abc[pos];
                    }
                    else
                    {
                        cifrado += pCadena[i];
                    }
                }
            }
            return cifrado;
        }
    }
}
