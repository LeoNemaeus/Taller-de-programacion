using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Lista los años biciestos comprendidos entre 1900 y 2015.
 * Estado: compila, ejecuta, funciona.
 * Mejoras: puede buscarse una forma de eliminar el write duplicado
 */
namespace ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            int año = 1900; //Declaración e inicialización de variables

            Console.WriteLine("Años biciestos entre 1900 y 2015:"); //Muestra en pantalla el mensaje

            while (año <= 2015)  // Ciclo que calcula los años bicietos hasta el año 2015 inclusive, dentro de la sensencia if calcula
            {                   // que el año sea divisible por 4 y que el resto del año dividido 100 sea distinto de 0 y los imprime en pantalla   
                {
                if (año % 4 == 0)
                
                    if (año % 100 != 0)
                    {
                        Console.Write(año + " ");
                    }
                    else if (año % 400 == 0)
                    {
                        Console.Write(año + " ");
                    }
                }
                año++; // Aumenta en uno la cantidad de la variable año
            }
            Console.ReadKey();
        }
    }
}
