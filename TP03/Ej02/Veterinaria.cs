using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej02
{
    class Veterinaria
    {
        public void AceptarAnimales(Animal[] pAnimales)
        {
            foreach (var animal in pAnimales)
            {
                animal.HacerRuido();
                animal.Correr();
                animal.Saltar();
                Console.WriteLine();
            }
        }
    }
}