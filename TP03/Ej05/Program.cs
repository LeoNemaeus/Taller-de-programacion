using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ej04;

namespace Ej05
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Fábrica de encriptadores");
            string frase = "";
            string resultado = "";
            string opcion, op1;
            do
            {
                Console.WriteLine("1) César");
                Console.WriteLine("2) AES");
                Console.WriteLine("3) Inverso");
                Console.WriteLine("S) Salir");
                Console.Write("Elija algoritmo de encriptación: ");
                opcion = Console.ReadLine();
                Console.WriteLine("");

                if (opcion != "0")
                {
                    switch (opcion)
                    {
                        case "1":
                            {
                                Console.WriteLine("-- Bienvenido al algoritmo César-- ");
                                Console.WriteLine("-Ingrese opción- ");
                                Console.WriteLine("a) Encriptar");
                                Console.WriteLine("b) Desencriptar");
                                Console.WriteLine("s) Salir");
                                op1 = Console.ReadLine();
                                if (op1 != "s")
                                {
                                    Console.Write("Ingrese frase: ");
                                    frase = Console.ReadLine();
                                    Console.Write("\n");
                                    switch (op1)
                                    {
                                        case "a":
                                            resultado = Fachada.Encriptar("César", frase);
                                            Console.WriteLine("Resul: " + resultado + "\n-----\n\n");
                                            break;
                                        case "b":
                                            resultado = Fachada.Desencriptar("César", frase);
                                            Console.WriteLine("Resul: " + resultado + "\n-----\n\n");
                                            break;
                                    }

                                }

                            }
                            break;
                        case "2":
                            {
                                Console.WriteLine("-- Bienvenido al algoritmo AES-- ");
                                Console.WriteLine("a) Encriptar");
                                Console.WriteLine("b) Desencriptar");
                                Console.WriteLine("s) Salir");
                                op1 = Console.ReadLine();
                                if (op1 != "s")
                                {
                                    Console.Write("Ingrese frase: ");
                                    frase = Console.ReadLine();
                                    Console.Write("\n");
                                    switch (op1)
                                    {
                                        case "a":
                                            resultado = Fachada.Encriptar("AES", frase);
                                            Console.WriteLine("Resul: " + resultado + "\n-----\n\n");

                                            break;
                                        case "b":
                                            resultado = Fachada.Desencriptar("AES", frase);
                                            Console.WriteLine("Resul: " + resultado + "\n-----\n\n");
                                            break;
                                    }

                                }

                            }
                            break;
                        case "3":
                            {
                                Console.WriteLine("-- Bienvenido al algoritmo César-- ");
                                Console.WriteLine("a) Encriptar");
                                Console.WriteLine("b) Desencriptar");
                                Console.WriteLine("s) Salir");
                                op1 = Console.ReadLine();
                                if (op1 != "s")
                                {
                                    Console.Write("Ingrese frase: ");
                                    frase = Console.ReadLine();
                                    Console.Write("\n");
                                    switch (op1)
                                    {
                                        case "a":
                                            resultado = Fachada.Encriptar("Inverso", frase);
                                            Console.WriteLine("Resul: " + resultado + "\n-----\n\n");
                                            break;
                                        case "b":
                                            resultado = Fachada.Desencriptar("Inverso", frase);
                                            Console.WriteLine("Resul: " + resultado + "\n-----\n\n");
                                            break;
                                    }

                                }
                            }
                            break;
                    }

                }
            }
            while (opcion != "0");
            Console.WriteLine("Hasta pronto");
            Console.ReadKey();
        }
    }
}