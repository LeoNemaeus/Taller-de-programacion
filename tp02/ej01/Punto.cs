using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej01
{
    // clase punto
    class Punto
    {
        // coordenadas x e y del punto
        private double iX, iY;

        // constructor: Punto(coordenada X, coordenada Y)
        // ambos valores deben ser de tipo double
        public Punto(double pX, double pY)
        {
            iX = pX;
            iY = pY;
        }

        // propiedad que devuelve un double equivalente a la coordenada X del punto
        public double X
        {
            get { return iX; }
        }

        // propiedad que devuelve un double equivalente a la coordenada Y del punto
        public double Y
        {
            get { return iY; }
        }

        // devuelve un double equivalente a la distancia entre el Punto
        // y otro Punto pPunto que se pasa como paramentro.
        public double CalcularDistanciaDesde(Punto pPunto)
        {
            return (Math.Sqrt(Math.Pow((iX - pPunto.X), 2) + Math.Pow((iY - pPunto.Y), 2)));
        }
    }
}
