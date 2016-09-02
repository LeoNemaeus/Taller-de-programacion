using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Imprima por pantalla “UNO”, “DOS”, “TRES”...“NUEVE”, “OTROS” si la variable
 * numero es igual a 1, 2, 3 … 9 o mayor utilizando la estructura switch.
*/

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicita un número
            Console.Write("Ingrese un número entero: ");
            int numAux = Convert.ToInt32(Console.ReadLine());

            //Determina el número ingresado y muestra el resultado
            switch (num)
            {
                case 1:
                    Console.WriteLine("Su número es: UNO");
                    break;
                case 2:
                    Console.WriteLine("Su número es: DOS");
                    break;
                case 3:
                    Console.WriteLine("Su número es: TRES");
                    break;
                case 4:
                    Console.WriteLine("Su número es: CUATRO");
                    break;
                case 5:
                    Console.WriteLine("Su número es: CINCO");
                    break;
                case 6:
                    Console.WriteLine("Su número es: SEIS");
                    break;
                case 7:
                    Console.WriteLine("Su número es: SIETE");
                    break;
                case 8:
                    Console.WriteLine("Su número es: OCHO");
                    break;
                case 9:
                    Console.WriteLine("Su número es: NUEVE");
                    break;
                default:
                    Console.WriteLine("Su número es: OTRO");
                    break;
            }
            Console.ReadLine();
        }
    }
}
