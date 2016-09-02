using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Devuelve el máximo, el mínimo y el promedio de una lista de números generados al azar
 * Estado: compila, ejecuta, funciona.
 */

namespace ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {                                        
            double[] nums = new Double[30]; //Definiciones e inicializaciones de variables
            Random randomizer = new Random();
            for (int i = 0; i <= 29; i++)
            {
                nums[i] = randomizer.NextDouble()*100; // Se le asigna al vector los numeros al azar
            }
            //Muestra en pantalla el resultado 
            Console.WriteLine("Máximo: " + nums.Max());
            Console.WriteLine("Mínimo: " + nums.Min());
            Console.WriteLine("Promedio: " + nums.Average());

            Console.ReadKey();
        }
    }
}
