using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej02
{
    public class Vaca : Animal
    {
        public override void HacerRuido()
        {
            Console.WriteLine("Sonido de la vaca: Muuuuuu Muuuuuu");
        }
    }
}
