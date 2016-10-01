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
            Fechas fecha = new Fechas(1, 1, 2000);

            Console.Write(fecha.DiaDeLaSemana);

            Console.ReadKey();
        }
    }
}


