using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej01
{
    class Program
    {
        static void Main(string[] args)
        {
            Veterinaria veterinaria = new Veterinaria();

            veterinaria.AceptarAnimales(new Animal[] { new Perro(), new Gato() });
        }
    }

}
