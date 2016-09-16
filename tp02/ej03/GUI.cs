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
            Console.Clear();
            Fachada.configurarIntentos(10);
            Console.WriteLine("Intentos: "+Fachada.intentos());

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
            Console.WriteLine("--------------------------------------------------");
            List<PartidaMuestra> top5 = Fachada.top5();
            int cant = top5.Count();
            for (int i=0; i<=4; i++)
            {
                if (i < cant)
                {
                    Console.WriteLine("===================={ TOP  " + (i + 1) + " }====================");
                    Console.WriteLine("Nombre Jugador: " + top5[i].NombreJugador + "\t\t" + top5[i].Palabra);
                    Console.WriteLine("Fecha:" + top5[i].FechaInicio + "\t" + top5[i].Duracion + "ms"+ top5[i].Resultado);
                }
                else
                {
                    Console.WriteLine("===================={ TOP  " + (i + 1) + " }====================");
                    Console.WriteLine("                --- No jugado ---\n");
                }
            }
            Console.ReadKey();
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
            do
            {

                Console.Clear();
                string p = Fachada.PalabraEnCurso;
                Console.WriteLine(PartidaActual.PalabraActual+"\n");
                Console.WriteLine(PartidaActual.PalabraEnCurso + "\n");
                for (int i=0; i<p.Length; i++)
                {
                    Console.Write("  " + p[i]);
                }
                
                Console.Write("\nLetras Acertadas:\t");
                imprimirLista(Fachada.LetrasAcertadas);
                Console.Write("\nLetras Intentadas:\t");
                imprimirLista(Fachada.LetrasIntentadas);
                Console.WriteLine("\nIntentos restantes: \t" + Fachada.intentos()+"\n");
                if (Fachada.PartidaEnCurso())
                {
                    Console.Write("\tIngrese proxima letra:");
                    Fachada.verificarLetra(Console.ReadLine().ToUpper().First());
                }
                
                
            }
            while (Fachada.PartidaEnCurso());
            Fachada.finalizarPartida();
            Console.WriteLine("\n");
            if (Fachada.verificarResultado())
            {
                Console.WriteLine("\tGANASTE! :D");
            }
            else { Console.WriteLine("\tte kbio pte :c"); }
            Console.ReadKey();
        }
        /*private static string estadoPalabra()
        {//TODO: reemplazar esta mierda
            string salida = "";
            string palabra = Fachada.PalabraActual;
            List<char> letrasIntentadas = Fachada.LetrasIntentadas;
            foreach (char L in palabra)
            {
                if (letrasIntentadas.Contains(L))
                {
                    salida += L+" ";
                }
                else { salida += "_ "; }
            }
            return salida;
        }*/

        private static void imprimirLista(List<char> unaLista)
        {
            foreach (char i in unaLista)
            {
                Console.Write(i+", ");
            }
        }
    }
}
