using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Invierte 5 cadenas pasadas como argunemntos.
 
namespace ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {   //Definición e inicialización de los arreglos y variables
            string[] c = new String[5];
            int i = 0, n = 4;
        
            //Usamos el foreach para obtener una cadena tomada de los argumentos.
            foreach (string cadena in args)
            {
                i = cadena.Length-1; // Le asignamos a i el tamaño de la cadena tomada.
                c[n] = ""; //Inicialización del arreglo

                //Usamos el While para ir invirtiendo la cadena tomando los caracteres desde la última posición, asignándola a la primera del arreglo.
                while (i >= 0)
                {
                    c[n] = String.Copy(String.Concat(c[n], cadena[i]));
                    i--;
                }
                n--;
            }
            //Ordenamos la cadena descendentemente.
            Array.Sort(c);
            Array.Reverse(c);

            foreach (string cadena in c)
            {
                Console.WriteLine(cadena);
            }

            Console.ReadKey();
        }
    }
}
