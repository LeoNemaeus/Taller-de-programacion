using System;
using System.Collections.Generic;
using System.Linq;

namespace ej03
{
    /// <summary cref="GUI">
    /// <para>Esta clase es la interfaz de consola con la que el usuario interactúa.</para>
    /// <para>Tiene todos los métodos de impresión.</para>
    /// </summary>
    class GUI
    {
        // int que representa la opción actual del menú principal.
        private static int opcion;

        /// <summary>
        /// <para>Inicia el menú principal y lo reimprime cada vez que se necesita.</para>
        /// <para>Para que el ciclo termine se debe ingresar la opción "0".</para>
        /// </summary>
        public static void iniciar()
        {
            Console.Clear();
            // imprimir el menu principal hasta salir.
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
                    case 0: break; // nada, solo salir.
                    case 1:
                        nuevaPartida(); // inicia nueva partida.
                        break;
                    case 2:
                        configurarIntentos(); // cambia la cantidad de veces que puedes fallar adivinando.
                        break;
                    case 3:
                        imprimirTop5(); // muestra las 5 victorias más rápidas.
                        break;
                } // fin switch
                Console.Clear();
            // "0" (cero) es la opcion de salida
            } while (opcion != 0);
        }

        /// <summary>
        /// Inicia una nueva partida para que se pueda jugar, seteando los valores iniciales
        /// e interactuando con el usuario mientras se juega.
        /// </summary>
        private static void nuevaPartida()
        {
            // éstas tres líneas setean el nombre del jugador y los datos iniciales de la partida.
            Console.Write("Para comenzar ingrese su nombre: ");
            string nombreJugador = Console.ReadLine();
            Fachada.nuevaPartida(nombreJugador);

            // el ciclo termina si la partida deja de estar en curso (si hay una condicion de fin).
            do
            {
                Console.Clear();
                Console.Write("\n\t-----{0}-----\n\n\n\n\t", nombreJugador);

                // ésto imprime los guines y las letras
                string p = Fachada.PalabraEnCurso;                
                for (int i = 0; i < p.Length; i++)
                {
                    Console.Write("  " + p[i]);
                }

                // lo siguiente imprime datos adicionales en cada intento
                Console.Write("\n\n\n\tLetras Acertadas:\t");
                imprimirLista(Fachada.LetrasAcertadas);
                Console.Write("\n\tLetras Intentadas:\t");
                imprimirLista(Fachada.LetrasIntentadas);
                Console.WriteLine("\n\tIntentos restantes: \t" + Fachada.IntentosRestantes + "\n");

                // ésto pide una nueva letra si aún se esta jugando
                if (Fachada.PartidaEnCurso())
                {
                    Console.Write("\n\tIngrese proxima letra:");
                    Fachada.verificarLetra(Console.ReadLine().ToUpper().First()); // siempre mayúsculas
                }
            }
            while (Fachada.PartidaEnCurso());

            // una vez que salga del ciclo del juego, seteamos los datos finales (como el tiempo final y el resultado).
            Fachada.finalizarPartida();
            Console.Clear();

            // lo siguiente imprime una cara feliz si se gana, o una triste si se pierde.
            // sí, los mensajes son horribles, lo se.
            if (Fachada.verificarResultado())
            {
                string ganaste = "░░░░░░░▄▄▀▀▀▀▀▀▀▀▀▀▄▄█▄░░░░▄░░░░█░░░░░░░\n░░░░░░█▀░░░░░░░░░░░░░▀▀█▄░░░▀░░░░░░░░░▄░\n░░░░▄▀░░░░░░░░░░░░░░░░░▀██░░░▄▀▀▀▄▄░░▀░░\n░░▄█▀▄█▀▀▀▀▄░░░░░░▄▀▀█▄░▀█▄░░█▄░░░▀█░░░░\n░▄█░▄▀░░▄▄▄░█░░░▄▀▄█▄░▀█░░█▄░░▀█░░░░█░░░\n▄█░░█░░░▀▀▀░█░░▄█░▀▀▀░░█░░░█▄░░█░░░░█░░░\n██░░░▀▄░░░▄█▀░░░▀▄▄▄▄▄█▀░░░▀█░░█▄░░░█░░░\n██░░░░░▀▀▀░░░░░░░░░░░░░░░░░░█░▄█░░░░█░░░\n██░░░░░░░░░░░░░░░░░░░░░█░░░░██▀░░░░█▄░░░\n██░░░░░░░░░░░░░░░░░░░░░█░░░░█░░░░░░░▀▀█▄\n██░░░░░░░░░░░░░░░░░░░░█░░░░░█░░░░░░░▄▄██\n░██░░░░░░░░░░░░░░░░░░▄▀░░░░░█░░░░░░░▀▀█▄\n░▀█░░░░░░█░░░░░░░░░▄█▀░░░░░░█░░░░░░░▄▄██\n░▄██▄░░░░░▀▀▀▄▄▄▄▀▀░░░░░░░░░█░░░░░░░▀▀█▄\n░░▀▀▀▀░░░░░░░░░░░░░░░░░░░░░░█▄▄▄▄▄▄▄▄▄██\n░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\n";
                Console.WriteLine("       GANASTE! BUEN TRABAJO! :D   \n\n{0}\n", ganaste);
            }
            else
            {
                string perdiste = "░░░░░░░░░░▄▄█▀▀▀▀▀▀▀▀█▄▄░░░░░░░░\n░░░░░░░▄▄▀▀░░░░░░░░░░░░▀▀▄▄░░░░░\n░░░░░▄█▀░░░░▄▀░░░░▄░░░░░░░▀█░░░░\n░░░░██▄▄████░░░░░░▀▄░░░░░░░░█▄░░\n░░▄████▀███▄▀▄░░░░░░███▄▄▄▄░░█░░\n░▄█████▄████░██░░░▄███▄▄░▀█▀░░█░\n▄███████▀▀░█░▄█░▄███▀█████░█░░▀▄\n█░█▀██▄▄▄▄█▀░█▀█▀██████▀░██▀█░░█\n█░█░▀▀▀▀▀░░░█▀░█░███▀▀░░▄█▀░█░░█\n█░░█▄░░░░▄▄▀░░░█░▀██▄▄▄██▀░░█▄░█\n█░░░░▀█▀▀▀░░░░░░█░░▀▀▀▀░░░░▄█░░█\n█░░░░░░░░░░░░░░░░▀▄░░░░░░▄█▀░░░█\n░█░░░░░░░░░░░░░░░░▀▀▀▀▀▀▀▄░░░░█░\n░░█░░░░░░▄▄▄▄▄▄▄░░░░░░░░░░░░░▄▀░\n░░░▀▄░░░░░▀█▄░░░▀▀██▄░░░░░░░▄▀░░\n░░░░░▀▄▄░░░░░▀▀▀▀▀░░░░░░░░▄▀░░░░\n░░░░░░░░▀▀▄▄▄░░░░░░░░▄▄▄▀▀█░░░░░\n░░░░░░░░░░▄▀▀█████▀▀▀▀░░░░██░░░░\n░░░░░░░░░█░░░██░░░█▀▀▀▀▀▀▀▀█░░░░";
                Console.WriteLine("       te kbió por manco :c\n\n{0}\n", perdiste);
            }
            Console.Write("\nLa palabra era: \"{0}\"\n", Fachada.PalabraActual);
            Console.Write("\n\n///// PRESIONE CUALQUIER TECLA PARA CONTINUAR /////");
            Console.ReadKey();
        }

        /// <summary>
        /// <para>Inicia el proceso de cambiar la cantidad de "vidas" que tendrá la próxima partida.</para>
        /// <para>El valor predeterminado es "10" (diez).</para>
        /// </summary>
        private static void configurarIntentos()
        {
            Console.Write("Ingrese los intentos deseados: ");
            Fachada.IntentosIniciales = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Los intentos fueron correctamente configurados a {0}!",Fachada.IntentosIniciales);
            Console.Write("\n///// PRESIONE CUALQUIER TECLA PARA CONTINUAR /////");
            Console.ReadKey();
        }

        /// <summary>
        /// <para>Imprime los datos de las 5 victorias más rápidas.</para>
        /// <para>Si no hay suficientes imprimirá las que haya.</para>
        /// </summary>
        private static void imprimirTop5()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("----------{ LAS CINCO MEJORES PARTIDAS }----------");
            Console.WriteLine("--------------------------------------------------");
            // lista de hasta PartidaMuestra que se iterarán para imprimirse.
            List<PartidaMuestra> top5 = Fachada.top5();
            int cant = top5.Count();
            for (int i = 0; i <= 4; i++)
            {
                if (i < cant) // esto está aquí por si hay menos de 5 partidas para mostrar.
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

        /// <summary>
        /// Método interno para imprimir los elementos dentro de una lista de carácteres.
        /// </summary>
        /// <param name="unaLista">La lista que se desea imprimir.</param>
        private static void imprimirLista(List<char> unaLista)
        {
            foreach (char i in unaLista)
            {
                Console.Write(i+", ");
            }
        }
    }
}
