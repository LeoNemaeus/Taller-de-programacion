using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Calcula el área y el perímetro del círculo del radio ingresado
 * Estado: compila, ejecuta, funciona.
 */

namespace ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {   // Definición de variables
            string aux;
            double radio, area, perimetro;
            //Toma el valor del radio ingresado por pantalla y lo asigna en la variable AUX 
            //para despues convertirlo y asignarlo en la variable RADIO.
            Console.WriteLine("Ingrese el radio del círculo: ");
            aux = Console.ReadLine();
            radio = Convert.ToDouble(aux);
            //Calcula el área y el perímetro del usando el radio ingresado.
            area = Math.PI * Math.Pow(radio, 2);
            perimetro = Math.PI * 2 * radio;
            //Muestra por pantalla los resultados del área y el perímetro calculados.
            Console.WriteLine("Area del circulo: " + area);
            Console.WriteLine("Perimetro del circulo: " + perimetro);

            Console.ReadKey();
        }
    }
}
