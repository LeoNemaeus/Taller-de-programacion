using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{   //m variables de metodo, p parametros, i instancia, b bloque
    class Punto
    {   // Atributos de la clase
        private double iX;  
        private double iY;

        //Constructores
        public Punto(double pX, double pY) 
        {
            this.iX = pX;
            this.iY = pY;
        }

        // Propiedades
        public double X  
        {
            get { return this.iX; }
        }

        public double Y
        {
            get { return this.iY; }
        }

        //Metodos
        public double CalcularDistanciaDesde(Punto pPunto)  // Metodo para calcular las distancias
        {
            return Math.Sqrt(Math.Pow((iX - pPunto.X), 2) + Math.Pow((iY - pPunto.Y), 2));
        }
    }
}
