using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej01
{
    class Program
    {
        static void Main(string[] args)
        {
            FachadaFiguras ctrl = new FachadaFiguras();
            string opción;
            double x, y, r, x1, x2, x3, y1, y2, y3;

            do
            {
                Console.Clear();
                Console.WriteLine("Cálculo de figuras - ingrese una opción:");
                Console.WriteLine("a - Calcular el perímetro de un círculo");
                Console.WriteLine("b - Calcular el área de un círculo");
                Console.WriteLine("c - Calcular el perímetro de un triángulo");
                Console.WriteLine("d - Calcular el área de un triángulo");
                Console.WriteLine("q - Salir");

                opción = Console.ReadLine();

                switch (opción) {
                    case "a":
                        Console.Clear();
                        Console.WriteLine("Calcular el perímetro de un círculo");

                        Console.Write("Coordenada x del centro: ");
                        x = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Coordenada y del centro: ");
                        y = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Radio: ");
                        r = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(
                            "Perímetro del círculo: {0}",
                            ctrl.CalcularPerímetroCírculo(x, y, r)
                            );

                        Console.Write("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case "b":
                        Console.Clear();
                        Console.WriteLine("Calcular el área de un círculo");

                        Console.Write("Coordenada x del centro: ");
                        x = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Coordenada y del centro: ");
                        y = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Radio: ");
                        r = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(
                            "Área del círculo: {0}",
                            ctrl.CalcularÁreaCírculo(x, y, r)
                            );

                        Console.Write("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case "c":
                        Console.Clear();
                        Console.WriteLine("Calcular el perímetro de un triángulo");

                        Console.Write("Coordenada x del punto 1: ");
                        x1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Coordenada y del punto 1: ");
                        y1 = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Coordenada x del punto 2: ");
                        x2 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Coordenada y del punto 2: ");
                        y2 = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Coordenada x del punto 3: ");
                        x3 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Coordenada y del punto 3: ");
                        y3 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine(
                            "Perímetro del triángulo: {0}",
                            ctrl.CalcularPerímetroTriángulo(x1, y1,
                                                            x2, y2,
                                                            x3, y3)
                            );

                        Console.Write("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case "d":
                        Console.Clear();
                        Console.WriteLine("Calcular el área de un triángulo");

                        Console.Write("Coordenada x del punto 1: ");
                        x1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Coordenada y del punto 1: ");
                        y1 = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Coordenada x del punto 2: ");
                        x2 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Coordenada y del punto 2: ");
                        y2 = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Coordenada x del punto 3: ");
                        x3 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Coordenada y del punto 3: ");
                        y3 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine(
                            "Área del triángulo: {0}",
                            ctrl.CalcularPerímetroTriángulo(x1, y1,
                                                            x2, y2,
                                                            x3, y3)
                            );

                        Console.Write("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            } while (opción != "q");
        }
    }
}
