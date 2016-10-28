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
            String iCadena, iCadenaEncriptada = "";
            Controlador controller = new Controlador();
            Console.WriteLine("Encriptar(1), Desencriptar(2), Salir(3)");
            int opcion = Convert.ToInt32(Console.ReadLine());
            while (opcion != 3)
            {
                Console.WriteLine("Ingrese nombre de encriptador: ");
                String iEncriptador = Console.ReadLine();
                switch (opcion)
                {
                    case 1:
                        {
                            Console.WriteLine("Ingrese la cadena: ");
                            iCadena = Console.ReadLine();
                            Console.WriteLine(iCadenaEncriptada = controller.EncriptarPalabra(iCadena, iEncriptador)); break;
                        }
                    case 2:
                        {

                            Console.WriteLine("Utilizar ultima cadena encriptada? si(1) no (2)");
                            if (Convert.ToInt32(Console.ReadLine()) == 1)
                            {
                                Console.WriteLine(controller.DesencriptarPalabra(iCadenaEncriptada, iEncriptador));
                            }
                            else
                            {
                                Console.WriteLine("Ingrese la cadena: ");
                                iCadena = Console.ReadLine();
                                try
                                {
                                    Console.WriteLine(controller.DesencriptarPalabra(iCadena, iEncriptador));
                                }
                                catch
                                {
                                    Console.WriteLine("ocurrio un error");
                                }
                            }
                            break;
                        }
                    default: { break; }
                }
                Console.WriteLine("Encriptar(1), Desencriptar(2), Salir(3)");
                opcion = Convert.ToInt32(Console.ReadLine());
            }


        }
    }
}
