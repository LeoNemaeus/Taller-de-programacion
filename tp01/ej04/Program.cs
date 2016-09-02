using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Imprima por pantalla la suma de los números de un límite inferior
 * (por ejemplo 5) hasta el límite superior (ejemplo 100). Muestre por pantalla
 * el promedio de los números ingresados. Los límites deben ser constantes.
 * Utiliza la sentencia while.
 */

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solita los límites y los lee
            Console.Write("Ingrese el límite inferior: ");
            int cLimInferior = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el límite superior: ");
            int cLimSuperior = Convert.ToInt32(Console.ReadLine());

            //Definición e inicialización de variables
            int cSuma = 0;

            int cCantNumeros = cLimSuperior - cLimInferior + 1;

            int i = cLimInferior;

            //Realiza la cSuma entre los límites ingresados
            while (i <= cLimSuperior)
            {
                cSuma += i;
                i++;
            }

            //Calcula el promedio, realizando castings para no perder información
            double cPromedio = (double) cSuma / (double) cCantNumeros;

            //Muestra en pantalla los resultados
            Console.WriteLine("Suma: " + cSuma);
            Console.WriteLine("Promedio: " + cPromedio);
            Console.ReadLine();
        }
    }
}
