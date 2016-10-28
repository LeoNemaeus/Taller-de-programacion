using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej04
{
    class Shell
    {
        public static void iniciar()
        {
            //Fachada.instanciarFabrica(); esto no va
            Console.WriteLine("============ ENCRIPTOMATICO ============");
            string frase = "== VACIOOOO ==";
            string resultado = "=== CADENA VACIA ===";
            string opcion;
            do
            {
                Console.WriteLine("\n1) Encriptar Cesar\n2) Desencriptar Cesar\n3) Encriptar AES\n4) Desencriptar AES\n");
                Console.Write("Ingrese opcion: ");
                opcion = Console.ReadLine();

                if (opcion != "0")
                {
                    Console.Write("\nFrase: ");
                    frase = Console.ReadLine();
                    Console.Write("\n");
                    switch (opcion)
                    {

                        case "1":
                            resultado = Fachada.Encriptar("César", frase);
                            // aca hay que hacer un menu, hay que pasar como parametro
                            // la palabra a encriptar o desencriptar, el encriptador, y si se quiere encrip o desencrip
                            break;
                        case "2":
                            resultado = Fachada.Desencriptar("César", frase);
                            break;
                        case "3":
                            resultado = Fachada.Encriptar("AES", frase);
                            break;
                        case "4":
                            resultado = Fachada.Desencriptar("AES", frase);
                            break;
                        default:                            
                            break;
                    }
                    Console.WriteLine("Resul: " + resultado + "\n-----\n\n");
                }

            } while (opcion != "0");
            Console.WriteLine("Gracias por usar el programa! :) por favor no vuelva. Nunca. Jamas.");
            Console.ReadKey();
        }
    }
}
