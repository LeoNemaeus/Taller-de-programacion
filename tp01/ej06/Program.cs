using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Desarrolle una aplicación que imprima por pantalla la suma de los números impares
de 1 a 100. Imprima el promedio también.*/

namespace ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {   //Declaración e inicialización de variables.
            int suma = 0;
            int n = 0;
            //Usamos el for para ir sumando los números impares, 
            //los cuales obtenemos mediante la sentencia IF, controlando si son divisibles por DOS.
            for (int i = 1; i <= 100; i++)
            {
                if ((i % 2) != 0)
                {
                    suma += i;
                    n++;
                }
            }
            //Calculamos el promedio, realizando castings en numerador y denominador para no perder información en los resultados.
            float promedio = (float) suma /(float) n;
            //Mostramos los resultados por pantala.
            Console.WriteLine("suma: " + suma);
            Console.WriteLine("promedio: " + promedio);
            Console.ReadLine();
        }
    }
}
