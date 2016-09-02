using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * define un arreglo de 50 números enteros, lo inicializa
 * y escribe ordenados ascendentemente por consola todos los números del arreglo que
 * estén comprendidos entre dos números definidos a través de constantes
 */

namespace ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declara e inicializa variables y constantes
            const int _limInferior = 500;
            const int _limSuperior = 5000;
            int[] arreglo = new int[50];
            Random aleatorio = new Random();

            //Inicializa el arreglo con números generados aleatoriamente
            for (int i = 0; i <= 49; i++)
            {
                arreglo[i] = Convert.ToInt32(aleatorio.Next()*0.000001);
            }

            //Ordena el arreglo de números
            arreglo = Program.ordenar(arreglo);

            //Muestra al usuario aquellos números que se encuentren entre los límites definidos.
            foreach (int numero in arreglo)
            {
                if ((numero > _limInferior) && (numero < _limSuperior)) Console.WriteLine(numero);
            }
            Console.ReadKey();
        }

        //Ordena un arreglo de enteros
        static int[] ordenar(int[] vector)
        {
            int aux;
            for (int i = 0; i < vector.Length; i++)
            {
                for(int j = 0; j < vector.Length - i - 1; j++)
                {
                    if (vector[j] < vector[j+1]) {
                        aux = vector[j];
                        vector[j] = vector[j + 1];
                        vector[j + 1] = aux;
                    }
                }
            }
            return vector;
        }
    }
}
