using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej02
{
    public class Pato : Animal
    {
        public override void HacerRuido()
        {
            Console.WriteLine("Sonido del pato: Cuack cuack cuack");
        }
    }
}
