using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP03
{
    public class Perro : Animal
    {
        public override void HacerRuido()
        {
            Console.WriteLine("Guau");
        }
    }
}
