using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP03
{
    public abstract class Animal

    {
        public void Correr()
        { Console.WriteLine("Corriendo");}

        public void Saltar ()
        {Console.WriteLine ("Saltando");}

        public abstract void HacerRuido();

    }

}

