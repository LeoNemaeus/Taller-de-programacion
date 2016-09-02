using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Desarrolle una aplicación que calcule y escriba por consola la suma de todos los
*números primos comprendidos entre 35 y 1977, incluyendo a estos valores.*/

namespace ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 35;  // Declaración e inicialización de variables
            int suma = 0;

            while (i <= 1977) // Ciclo que calcula si contarDivisores es igual a 2, seria un número primo y lo ingresa a la varia suma.
            {
                if (contarDivisores(i) == 2) {
                    suma += i;
                }

                i++;
            }

            Console.WriteLine("Suma de números primos: {0}", suma);
            Console.ReadLine();
        }

        static int contarDivisores (int n)  // Cuenta la cantidad de números divisores, si es divisor por 1 y por si mismo y los guarda en la variable.
        {
            int i = 1;
            int divisores = 0;
            while (i <= n)
            {
                if (n % i == 0) { divisores++; }
                i++;
            }

            return divisores;
        }
    }
}
