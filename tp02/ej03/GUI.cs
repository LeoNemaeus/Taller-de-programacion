using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej03
{
    /// <summary cref="GUI">
    /// <para>Esta clase es la interfaz de consola con la que el usuario interactúa.</para>
    /// <para>Tiene todos los métodos de impresión.</para>
    /// </summary>
    class GUI
    {
        private static int opcion;

        //private GUI() { }
        
        public static void iniciar()
        {
            Console.Clear();            
            do
            {
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("-------------------{ Ahorcado }-------------------");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("1- Nueva partida.");
                Console.WriteLine("2- Configurar numero de fallos.");
                Console.WriteLine("3- TOP 5!");
                Console.WriteLine("0- Salir.");
                Console.Write(">>> ");
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
                } // fin switch
                Console.Clear();
            } while (opcion != 0);
        } // fin iniciar


        private static void imprimirTop5()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("--------------------{ TOP  5 }--------------------");
            Console.WriteLine("--------------------------------------------------\n");
            List<PartidaMuestra> top5 = Fachada.top5();
            int cant = top5.Count();
            for (int i=0; i<=4; i++)
            {
                if (i < cant)
                {
                    Console.WriteLine("===================={ TOP  " + (i + 1) + " }====================");
                    Console.WriteLine("Nombre Jugador: " + top5[i].NombreJugador + "\t\t" + top5[i].Palabra);
                    Console.WriteLine("Fecha:" + top5[i].FechaInicio + "\t" + top5[i].Duracion + "ms\n");
                }
                else
                {
                    Console.WriteLine("===================={ TOP  " + (i + 1) + " }====================");
                    Console.WriteLine("                --- No jugado ---\n\n");
                }
            }
            Console.WriteLine("///// PRESIONE CUALQUIER TECLA PARA CONTINUAR /////");
            Console.ReadKey();
        }

        private static void configurarIntentos()
        {
            Console.Write("Ingrese los intentos deseados: ");
            Fachada.IntentosIniciales = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Los intentos fueron correctamente configurados a {0}!",Fachada.IntentosIniciales);
            Console.Write("\n///// PRESIONE CUALQUIER TECLA PARA CONTINUAR /////");
            Console.ReadKey();
        }

        private static void nuevaPartida()
        {
            Console.Write("Para comenzar ingrese su nombre: ");
            string nombreJugador = Console.ReadLine();
            Fachada.nuevaPartida(nombreJugador);
            do
            {

                Console.Clear();
                string p = Fachada.PalabraEnCurso;
                Console.Write("\n\t-----{0}-----\n\n\n\n\t", nombreJugador);
                for (int i=0; i<p.Length; i++)
                {
                    Console.Write("  " + p[i]);
                }
                
                Console.Write("\n\n\n\tLetras Acertadas:\t");
                imprimirLista(Fachada.LetrasAcertadas);
                Console.Write("\n\tLetras Intentadas:\t");
                imprimirLista(Fachada.LetrasIntentadas);
                Console.WriteLine("\n\tIntentos restantes: \t" + Fachada.IntentosRestantes+"\n");
                if (Fachada.PartidaEnCurso())
                {
                    Console.Write("\n\tIngrese proxima letra:");
                    Fachada.verificarLetra(Console.ReadLine().ToUpper().First());
                }
            }
            while (Fachada.PartidaEnCurso());
            Fachada.finalizarPartida();
            Console.Clear();
            if (Fachada.verificarResultado())
            {
                string ganaste = "░░░░░░░▄▄▀▀▀▀▀▀▀▀▀▀▄▄█▄░░░░▄░░░░█░░░░░░░\n░░░░░░█▀░░░░░░░░░░░░░▀▀█▄░░░▀░░░░░░░░░▄░\n░░░░▄▀░░░░░░░░░░░░░░░░░▀██░░░▄▀▀▀▄▄░░▀░░\n░░▄█▀▄█▀▀▀▀▄░░░░░░▄▀▀█▄░▀█▄░░█▄░░░▀█░░░░\n░▄█░▄▀░░▄▄▄░█░░░▄▀▄█▄░▀█░░█▄░░▀█░░░░█░░░\n▄█░░█░░░▀▀▀░█░░▄█░▀▀▀░░█░░░█▄░░█░░░░█░░░\n██░░░▀▄░░░▄█▀░░░▀▄▄▄▄▄█▀░░░▀█░░█▄░░░█░░░\n██░░░░░▀▀▀░░░░░░░░░░░░░░░░░░█░▄█░░░░█░░░\n██░░░░░░░░░░░░░░░░░░░░░█░░░░██▀░░░░█▄░░░\n██░░░░░░░░░░░░░░░░░░░░░█░░░░█░░░░░░░▀▀█▄\n██░░░░░░░░░░░░░░░░░░░░█░░░░░█░░░░░░░▄▄██\n░██░░░░░░░░░░░░░░░░░░▄▀░░░░░█░░░░░░░▀▀█▄\n░▀█░░░░░░█░░░░░░░░░▄█▀░░░░░░█░░░░░░░▄▄██\n░▄██▄░░░░░▀▀▀▄▄▄▄▀▀░░░░░░░░░█░░░░░░░▀▀█▄\n░░▀▀▀▀░░░░░░░░░░░░░░░░░░░░░░█▄▄▄▄▄▄▄▄▄██\n░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\n";
                Console.WriteLine("       GANASTE! BUEN TRABAJO! :D   \n\n{0}\n",ganaste);
            }
            else
            {
                string perdiste = "░░░░░░░░░░▄▄█▀▀▀▀▀▀▀▀█▄▄░░░░░░░░\n░░░░░░░▄▄▀▀░░░░░░░░░░░░▀▀▄▄░░░░░\n░░░░░▄█▀░░░░▄▀░░░░▄░░░░░░░▀█░░░░\n░░░░██▄▄████░░░░░░▀▄░░░░░░░░█▄░░\n░░▄████▀███▄▀▄░░░░░░███▄▄▄▄░░█░░\n░▄█████▄████░██░░░▄███▄▄░▀█▀░░█░\n▄███████▀▀░█░▄█░▄███▀█████░█░░▀▄\n█░█▀██▄▄▄▄█▀░█▀█▀██████▀░██▀█░░█\n█░█░▀▀▀▀▀░░░█▀░█░███▀▀░░▄█▀░█░░█\n█░░█▄░░░░▄▄▀░░░█░▀██▄▄▄██▀░░█▄░█\n█░░░░▀█▀▀▀░░░░░░█░░▀▀▀▀░░░░▄█░░█\n█░░░░░░░░░░░░░░░░▀▄░░░░░░▄█▀░░░█\n░█░░░░░░░░░░░░░░░░▀▀▀▀▀▀▀▄░░░░█░\n░░█░░░░░░▄▄▄▄▄▄▄░░░░░░░░░░░░░▄▀░\n░░░▀▄░░░░░▀█▄░░░▀▀██▄░░░░░░░▄▀░░\n░░░░░▀▄▄░░░░░▀▀▀▀▀░░░░░░░░▄▀░░░░\n░░░░░░░░▀▀▄▄▄░░░░░░░░▄▄▄▀▀█░░░░░\n░░░░░░░░░░▄▀▀█████▀▀▀▀░░░░██░░░░\n░░░░░░░░░█░░░██░░░█▀▀▀▀▀▀▀▀█░░░░";
                Console.WriteLine("       te kbió por manco :c\n\n{0}\n",perdiste);
                //TODO: el top 5 se rompe con las derrotas
            }
            Console.Write("\nLa palabra era: \"{0}\"\n", Fachada.PalabraActual);
            Console.Write("\n\n///// PRESIONE CUALQUIER TECLA PARA CONTINUAR /////");
            Console.ReadKey();
        }
        private static void imprimirLista(List<char> unaLista)
        {
            foreach (char i in unaLista)
            {
                Console.Write(i+", ");
            }
        }
    }
}
