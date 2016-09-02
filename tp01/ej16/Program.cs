using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Permite ingresar dos cadenas de caracteres por teclado,
 * determine si son anagramas y escriba el resultado de dicha
 * comprobación por consola.
*/

namespace ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Definición de inicialización de variables
            bool esAnagrama = true;
            int n;
            char car;

            //Solicita al usuario que ingrese las cadenas y las lee.
            Console.Write("Ingrese la primer cadena: ");
            string cad1 = Console.ReadLine();
            Console.Write("Ingrese la segunda cadena: ");
            string cad2 = Console.ReadLine();

            while((cad1.Length > 0) & (esAnagrama))
            {
                //Selecciona un caracter de la primer cadena y lo busca en la segunda.
                car = cad1.ElementAt(0);
                n = cad2.IndexOf(car);

                /*
                 * Si encuentra el caracter seleccionado lo remueve de ambas cadenas.
                 * Sino se puede asegurar que las cadenas no son anagramas
                 */
                if (n != -1)
                {
                    cad2 = cad2.Remove(n, 1);
                    cad1 = cad1.Remove(0, 1);
                } else
                {
                    esAnagrama = false;
                }
            }
            
            /*
             * Si todos los caracteres en la primer cadena tienen un correspondiente
             * en la segunda, ambas cadenas deberían ser vacías.
             */
            if ((cad1 == "") & (cad2==""))
            {
                Console.WriteLine("Anagrama");
            } else
            {
                Console.WriteLine("No Anagrama");
            }

            Console.ReadKey();

            return;
            
        }
    }
}
