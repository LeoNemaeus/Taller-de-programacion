using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la parte real del número complejo: ");
            double iReal = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la parte imaginaria del número complejo: ");
            double iImaginario = Convert.ToDouble(Console.ReadLine());

            Complejo iComplejo = new Complejo (iReal,iImaginario);

            string opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("Elija una operación a realizar con su número: ");
                Console.WriteLine("a) Comparar con otro complejo.");
                Console.WriteLine("b) Sumar con otro complejo.");
                Console.WriteLine("c) Restar con otro complejo.");
                Console.WriteLine("d) Multiplicar por otro complejo.");
                Console.WriteLine("e) Dividir por otro complejo.");
                Console.WriteLine("q) SALIR.");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "a":
                        Console.Write("Ingrese la parte real del complejo con el que desea comparar: ");
                        double iR = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese la parte imaginaria del complejo con el que desea comparar: ");
                        double iIm = Convert.ToDouble(Console.ReadLine());

                        if (iComplejo.EsIgual(iR, iIm))
                        {
                            Console.Write("Los números son iguales.");
                        }
                        else
                        {
                            Console.Write("Los números no son iguales. ");
                        }

                        Console.ReadKey();
                        break;
                    case "b":
                        Console.Write("Ingrese la parte real del complejo a sumar:");
                        double iR1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese la parte imaginaria del complejo a sumar: ");
                        double iIm1 = Convert.ToDouble(Console.ReadLine());
                        Complejo iCompl = new Complejo(iR1, iIm1);
                        iCompl = iComplejo.Sumar(iCompl);
                        Console.Write("El resultado de la suma es {0} + {1}i", iCompl.Real, iCompl.Imaginario);

                        Console.ReadKey();
                        break;


                }




            } while (opcion != "q");

        }
    }
}
