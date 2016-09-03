using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej01
{
    class Punto
    {
        private double iX, iY;

        public Punto(double pX, double pY)
        {
            iX = pX;
            iY = pY;
        }

        public double X
        {
            get { return iX; }
        }

        public double Y
        {
            get { return iY; }
        }

        public double CalcularDistanciaDesde(Punto pPunto)
        {
            return (Math.Sqrt(Math.Pow((iX - pPunto.X), 2) + Math.Pow((iY - pPunto.Y), 2)));
        }
    }
}
