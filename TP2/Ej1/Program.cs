using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    class FiguraGeometrica
    {
        static void Main(string[] args)

        {
            string opc;
            FachadaFigura fachada = new FachadaFigura();
            {
                do
                {
                    Console.WriteLine("Ingrese la figura que desea calcular: ");
                    Console.WriteLine("1- Calculo del Perimetro y Area del Circulo");
                    Console.WriteLine("2- Calculo del Perimetro y Area del Triangulo");
                    Console.WriteLine("s- Salir");
                    {
                        opc = Console.ReadLine();
                        switch (opc)
                        {
                            case "1":
                                {
                                    Console.WriteLine("Ingrese coordenada X: ");
                                    int cX = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Ingrese coordenada Y: ");
                                    int cY = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Ingrese radio: ");
                                    int cRad = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("El Area es: {0:0.00}",
                                    fachada.CalcularAreaCirculo(cX, cY, cRad));
                                    Console.WriteLine("El perimetro es: {0:0.00}",
                                    fachada.CalcularPerimetroCirculo(cX, cY, cRad));
                                    Console.ReadKey();
                                    break;
                                }

                            case "2":
                                {
                                    Console.WriteLine("Ingrese primer coordenada X1: ");
                                    int X1 = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Ingrese primer coordenada Y1: ");
                                    int Y1 = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Ingrese segunda coordenada X2: ");
                                    int X2 = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Ingrese segunda coordenada Y2: ");
                                    int Y2 = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Ingrese tercer coordenada X3: ");
                                    int X3 = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Ingrese tercer coordenada Y3: ");
                                    int Y3 = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("El Area del triangulo es: {0:0.0} Y El perimetro es: {1:0.00}",
                                        fachada.CalcularAreaTriangulo(X1, Y1, X2, Y2, X3, Y3),
                                        fachada.CalcularPerimetroTriangulo (X1, Y1, X2, Y2, X3, Y3));
                                    Console.ReadKey();
                                    break;
                                }

                        }
                    }


                }
                while (opc == "s");
                Console.ReadKey();
                Console.Clear();


            }
        }
    }
}