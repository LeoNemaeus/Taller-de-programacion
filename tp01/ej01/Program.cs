using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Imprima por pantalla “UNO”, “DOS”, “TRES”...“NUEVE”, “OTROS” si la variable
 * numero es igual a 1, 2, 3 … 9 ó mayor
*/

namespace TP1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Solicita que se ingrese un número
            Console.Write("Ingrese un número entero: ");
            string numAux = Console.ReadLine();

            //Convierte el string leido en entero.
            int num = Convert.ToInt32(numAux);

            /*
             * Determina que número fue ingresado.
             */
            if (num == 1)
            {
                Console.WriteLine("Su número es: UNO");
            }
            else if (num == 2)
            {
                Console.WriteLine("Su número es: DOS");
            }
            else if (num == 3)
            {
                Console.WriteLine("Su número es: TRES");
            }
            else if (num == 4)
            {
                Console.WriteLine("Su número es: CUATRO");
            }
            else if (num == 5)
            {
                Console.WriteLine("Su número es: CINCO");
            }
            else if (num == 6)
            {
                Console.WriteLine("Su número es: SEIS");
            }
            else if (num == 7)
            {
                Console.WriteLine("Su número es: SIETE");
            }
            else if (num == 8)
            {
                Console.WriteLine("Su número es: OCHO");
            }
            else if (num == 9)
            {
                Console.WriteLine("Su número es: NUEVE");
            }
            else
            {
                Console.WriteLine("Su número es: OTRO");
            }
            Console.ReadLine();
        }
    }
}
