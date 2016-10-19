using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej02
{
    public class Perro : Animal
    {
        public override void HacerRuido()
        {
            Console.WriteLine("Sonido del perro: Guau guau guau");
        }
    }
}
