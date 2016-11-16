using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el Dividendo: .");
            int iDividendo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el Divisor: .");
            int iDivisor = Convert.ToInt32(Console.ReadLine());

            try
            {
                double iResultado = Matematica.Dividir(iDividendo, iDivisor);
                Console.WriteLine("El Resuldado es: " + iResultado);
            }
            catch (DivisionPorCeroException e)
                {
                    Console.WriteLine("El divisor ingresado es cero: ");
                    Console.WriteLine(e.Message);
                    Console.WriteLine(e.StackTrace);
                }
           
            Console.ReadKey();

        }
    }
}
