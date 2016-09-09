using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej03
{
    class GUI
    {
        private static int opcion;

        private GUI() { }
        
        public static void iniciar()
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("-------------------{ Ahorcado }-------------------");
            do
            {
                Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("1- Nueva partida.");
            Console.WriteLine("2- Configurar numero de fallos.");
            Console.WriteLine("3- TOP 5!");
            Console.WriteLine("0- Salir.");
            opcion = Int32.Parse(Console.ReadLine());
            
                switch (opcion)
                {
                    case 0: break;
                    case 1:
                        nuevaPartida();
                        break;
                    case 2:
                        configurarIntentos();
                        
                        break;
                    case 3:
                        imprimirTop5();
                        break;
                }
            } while (opcion != 0);
        }


        private static void imprimirTop5()
        {
            Fachada.top5();
            // TODO: hacer top 5 mostrar
        }

        private static void configurarIntentos()
        {
            Console.Write("Ingrese los intentos deseados: ");
            Fachada.configurarIntentos(Int32.Parse(Console.ReadLine()));
        }

        private static void nuevaPartida()
        {
            Console.Write("Para comenzar ingrese su nombre: ");
            Fachada.nuevaPartida(Console.ReadLine());
        }
    }
}
