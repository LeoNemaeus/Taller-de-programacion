using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Calcula el factorial del número ingresado.
 * Estado: compila, ejecuta, funciona
 */

namespace ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n, factorial = 1; //Definiciones e inicializaciones de variables

            Console.WriteLine("Ingreses el número al que desea calcular el factorial: "); //Muestra en pantalla el mensaje 
            n = Convert.ToInt32(Console.ReadLine()); // Se le asigna a la variable n el valor que se ingrese manualmente

            while (n > 1)   // Ciclo ene el que ingresa mientras n sea mayor que el valor 1
            {               // se le asigna a la variable factorial el calculo a realizar.
                factorial *= n;
                n--;
            }

            Console.WriteLine("Factorial: " + factorial);   //Muestra pantalla el mensaje declarado con el resultado final de la variable.
            Console.ReadKey();
        }
    }
}
