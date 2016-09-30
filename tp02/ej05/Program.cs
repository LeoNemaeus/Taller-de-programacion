using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Agregar días.
· Agregar meses.
· Agregar años.
· Devolver el componente día de la fecha.
· Devolver el componente mes de la fecha.
· Devolver el componente año de la fecha.
· Devolver el nombre del día de la semana (Lunes, Martes, etc.) de la fecha.
· Indicar si el componente año de la fecha es bisiesto.
· Comparar dos fechas.*/

namespace Ej05
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string opc;

            do
            {
                Console.Clear();
                Console.WriteLine("1) Ingresar día - mes - año");
                Console.WriteLine("2) Calcular fecha a partir de días");
                Console.WriteLine("3) Comparar dos fechas");
                opc = Console.ReadLine();

                switch (opc)
                {
                    case "1":

                        Console.WriteLine("Ingrese dia (aa): ");
                        int xDia = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese Mes (mm): ");
                        int xMes = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese Año (aaaa): ");
                        int xAño = Convert.ToInt32(Console.ReadLine());

                        Fechas iFecha = new Fechas(xDia, xMes, xAño);

                        Console.WriteLine("Fecha ingresada: ", iFecha.Dia, "/", iFecha.Mes, "/", iFecha.Año);

                        Console.ReadKey();

                        Console.WriteLine("El componente dia es: ", xDia);
                        Console.WriteLine("El componente mes es: ", xMes);
                        Console.WriteLine("El componente año es: ", xAño);
                        Console.WriteLine("El día de la fecha es: ", iFecha.DiaDeLaSemana);
                        Console.WriteLine("El día de la fecha es: ", iFecha.DiaDeLaSemana);
                        if (iFecha.EsBisiesto())
                            Console.WriteLine("El año es bisiesto");
                        else
                            Console.WriteLine("El año no es bisiesto");
                        Console.Clear();
                        break;

                    case "2":
                        Console.WriteLine("Ingrese cantidad de días para calcular una fecha: ");
                        int xDias = Convert.ToInt32(Console.ReadLine());
                        Console.ReadKey();
                        Console.WriteLine("La fecha calculada: ", iFecha.AgregarAños(xDias));
                        break;

                    /*case "3":
                        Console.WriteLine("Ingrese fecha a comparar: ");
                        Console.WriteLine("Ingrese dia (aa): ");
                        int xDia = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese Mes (mm): ");
                        int xMes = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese Año (aaaa): ");
                        int xAño = Convert.ToInt32(Console.ReadLine());
                        break;*/

                    case "s":
                        Console.WriteLine("Gracias por usar el software");
                        break;
                }
            } while (opc != "s");
            Console.ReadKey();


        }
    }
}


