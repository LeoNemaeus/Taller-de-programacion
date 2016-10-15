using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej02
{
    class Program
    {
        static void Main(string[] args)
        {
            Veterinaria veterinaria = new Veterinaria();

            veterinaria.AceptarAnimales(new Animal[] { new Perro(), new Gato(), new Pollito(), new Pato(), new Vaca() });
        }
    }

}