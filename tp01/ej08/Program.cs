using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *  desarrolle una aplicacion que imprima por pantalla los 50 primeros terminos
 *  de la sucesion de fiboanacci
 */
namespace ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Declaración e inicialización de variables.
            * a y b son los valores iniciales. Sum es una variable auxiliar
            * incrementar el valor de las anteriores.
            */
            long a = 1, b = 1, sum = 0;

            for(int i = 1; i <=50; i++)
            {
                //En cada  iteración se indica el número actual de la serie
                Console.WriteLine("Término número: {0}: {1}", i, a);
                sum = a + b;
                a = b;
                b = sum;
            }

            Console.ReadKey();

        }
    }
}
