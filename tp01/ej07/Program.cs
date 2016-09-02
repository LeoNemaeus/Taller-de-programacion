using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Desarrolle una aplicación que calcule aproximadamente el número π con la fórmula
de Lebniz. Determine el criterio de fin de cálculo, que puede ser la cantidad de términos utilizados. La
API de C# posee una constante con el valor de dicho número (Math.PI), compare el
resultado del cálculo con la constante en términos porcentuales.
 */
namespace ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {   //Definición de variable.
            double error;
            //Solicita la cantidad de términos para calcular y lo asigna a la variable aux que luego convierte para trabajar en INT.
            Console.Write("ingrese la cantidad de términos a calcular: ");
            string aux = Console.ReadLine();
            int n = Convert.ToInt32(aux);
            //Inicialización y declaración de variables
            int i = 0;
            double suma = 0;
            //Aplica la fórmula de leibniz dependiendo la cantidad n de términos que se estableció por pantalla anteriormente.
            while (i <= n)
            {
                suma += Math.Pow(-1, Convert.ToDouble(i)) / (2 * i + 1); //Fórmula de Leibniz: eleva -1 a la i y luego lo divide.
                i++;
            }
            //Calcula el error, en términos porcentuales, para comparar con la constante PI que ya está establecida por el programa.
            error = (suma - Math.PI/4) / (Math.PI/4)*100;
            error = Math.Abs(error);
            //Se muestran los resultados por pantalla.
            Console.WriteLine("Resultado suma de Lebniz: " + suma);
            Console.WriteLine("Pi/4: " + Math.PI/4);
            Console.WriteLine("Error porcentual: " + error + "%");
            Console.ReadKey();
        }
    }
}
