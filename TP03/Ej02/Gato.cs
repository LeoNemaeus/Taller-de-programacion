using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej02
{
    public class Gato : Animal
    {
        public override void HacerRuido()
        {
            Console.WriteLine("Sonido del gato: Miau miau miau");
        }
    }
}