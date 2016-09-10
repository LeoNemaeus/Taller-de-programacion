using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej05
{
    class Program
    {
        static void Main(string[] args)
        {

            Fechas fecha = new Fechas(pDia, pMes, pAño)


            {

            Console.WriteLine("Ingrese dia (aa): ");
            int xDia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese Mes (mm): ");
            int xMes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese Año (aaaa): ");
            int xAño = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fecha ingresada: ", xDia, "/", xMes, "/", xAño);
            Console.ReadKey();
        }
    }
}
}




