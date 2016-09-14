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
            } while (opcion != 0);
        } // fin iniciar


        private static void imprimirTop5()
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("--------------------{ TOP  5 }--------------------");
            Console.WriteLine("--------------------------------------------------");
            List<PartidaMuestra> top5 = Fachada.top5();
            for (int i=0; i<=4; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("                 ---{ TOP  "+(i+1)+" }---");
                Console.WriteLine("Nombre Jugador: "+top5[i].NombreJugador+ "\t\t" + top5[i].Palabra);
                Console.WriteLine("Fecha:"+top5[i].FechaInicio + "\t\t("+top5[i].Duracion+"ms)");
            }
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
                
                string p = Fachada.PalabraEnCurso;
                for (int i=0; i<p.Length; i++)
                {
                    Console.Write("  " + p[i]);
                }
                Console.WriteLine("Letras Acertadas:\t" + Fachada.LetrasAcertadas);
                Console.WriteLine("Letras Intentadas:\t" + Fachada.LetrasIntentadas);
                Console.WriteLine("---------------------------------");
                
                Console.Write("\tIngrese proxima letra:");
                Fachada.verificarLetra(Console.ReadLine().First());
            }
            while (Fachada.PartidaEnCurso()==true);
            Console.WriteLine("\n");            
        }
        private static string estadoPalabra()
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
        }
    }
}
