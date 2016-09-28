using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej04
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
            Console.Write("El complejo con el que trabajará es: {0}+{1}i",iComplejo.Real,iComplejo.Imaginario);
            Console.WriteLine();

            string opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("Elija una operación a realizar con su número: ");
                Console.WriteLine("a) COMPARAR con otro complejo.");
                Console.WriteLine("b) SUMAR con otro complejo.");
                Console.WriteLine("c) RESTAR con otro complejo.");
                Console.WriteLine("d) MULTIPLICAR por otro complejo.");
                Console.WriteLine("e) DIVIDIR por otro complejo.");
                Console.WriteLine("f) Devolver el complejo CONJUGADO.");
                Console.WriteLine("g) Devolver ARGUMENTO EN RADIANES.");
                Console.WriteLine("h) Devolver ARGUMENTO EN GRADOS.");
                Console.WriteLine("i) Calcular MAGNITUD del Complejo.");
                Console.WriteLine("j) Indicar si el complejo es REAL o IMAGINARIO.");
                Console.WriteLine();
                Console.WriteLine("q) SALIR.");
                Console.WriteLine();
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "a":
                        Console.Write("Ingrese la parte real del complejo con el que desea comparar: ");
                        double iRa = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese la parte imaginaria del complejo con el que desea comparar: ");
                        double iIma = Convert.ToDouble(Console.ReadLine());

                        if (iComplejo.EsIgual(iRa, iIma))
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
                        double iRb = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese la parte imaginaria del complejo a sumar: ");
                        double iImb = Convert.ToDouble(Console.ReadLine());
                        Complejo iComplb = new Complejo(iRb, iImb);
                        iComplb = iComplejo.Sumar(iComplb);
                        Console.Write("El resultado de la suma es {0} + {1}i", iComplb.Real, iComplb.Imaginario);
                        Console.ReadKey();
                        break;

                    case "c":
                        Console.Write("Ingrese la parte real del complejo a restar:");
                        double iRc = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese la parte imaginaria del complejo a sumar: ");
                        double iImc = Convert.ToDouble(Console.ReadLine());
                        Complejo iComplc = new Complejo(iRc, iImc);
                        iComplc = iComplejo.Restar(iComplc);
                        Console.Write("El resultado de la resta es {0} + {1}i", iComplc.Real, iComplc.Imaginario);
                        Console.ReadKey();
                        break;

                    case "d":
                        Console.Write("Ingrese la parte real del complejo a multiplicar:");
                        double iRd = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese la parte imaginaria del complejo a multiplicar: ");
                        double iImd = Convert.ToDouble(Console.ReadLine());
                        Complejo iCompld = new Complejo(iRd, iImd);
                        iCompld = iComplejo.MultiplicarPor(iCompld);
                        Console.Write("El resultado de la multiplicación es {0} + {1}i", iCompld.Real, iCompld.Imaginario);
                        Console.ReadKey();
                        break;

                    case "e":
                        Console.Write("Ingrese la parte real del complejo a dividir:");
                        double iRe = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese la parte imaginaria del complejo a dividir: ");
                        double iIme = Convert.ToDouble(Console.ReadLine());
                        Complejo iComple = new Complejo(iRe, iIme);
                        iComple = iComplejo.DividirPor(iComple);
                        Console.Write("El resultado de la división es {0} + {1}i", iComple.Real, iComple.Imaginario);
                        Console.ReadKey();
                        break;
                    case "f":
                        Console.Write("El CONJUGADO de su complejo es el complejo {0}{1}i",iComplejo.Conjugado.Real, 
                                                                                           iComplejo.Conjugado.Imaginario);
                        Console.ReadKey();
                        break;
                    case "g":
                        Console.Write("El ARGUMENTO en RADIANES de su complejo es: " + iComplejo.ArgumentoEnRadianes);
                        Console.ReadKey();
                        break;
                    case "h":
                        Console.Write("El ARGUMENTO en GRADOS de su complejo es: " + iComplejo.ArgumentoEnGrados);
                        Console.ReadKey();
                        break;
                    case "i":
                        Console.Write("La MAGNITUD de su complejo es: " + iComplejo.Magnitud);
                        Console.ReadKey();
                        break;
                }

            } while (opcion != "q");

        }
    }
}
