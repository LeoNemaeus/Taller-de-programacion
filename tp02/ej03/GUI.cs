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
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("1- Nueva partida.");
            Console.WriteLine("2- Configurar numero de fallos.");
            Console.WriteLine("3- TOP 5!");
            Console.WriteLine("0- Salir.");
            opcion = Int32.Parse(Console.ReadLine());
            do
            {
                switch (opcion)
                {
                    case 0: break;
                    case 1:
                        nuevaPartida();
                        break;
                    case 2:
                        configurarIntentos();
                        //Console.Write("ingrese los intentos deseados: ");
                        //Fachada.configurarIntentos(Int32.Parse(Console.ReadLine()));
                        break;
                    case 3:
                        imprimirTop5();
                        break;
                }
            } while (opcion != 0);
        }

        // hacer
        private static void imprimirTop5()
        {
            throw new NotImplementedException();
        }

        private static void configurarIntentos()
        {
            throw new NotImplementedException();
        }

        private static void nuevaPartida()
        {
            throw new NotImplementedException();
        }
    }
}
