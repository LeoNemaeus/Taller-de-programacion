using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej02
{
    public abstract class Animal

    {
        public void Correr()
        { Console.WriteLine("Corriendo");}
        
        public void Saltar()
        { Console.WriteLine("Saltando");
          Console.ReadKey();
        }
        public abstract void HacerRuido();
    }
}
