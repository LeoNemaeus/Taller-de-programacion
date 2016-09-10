using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    class Triangulo
    {   // Atributos de la clase
        private Punto iPunto1;
        private Punto iPunto2;
        private Punto iPunto3;

        //Constructores
        public Triangulo(Punto pPunto1, Punto pPunto2, Punto pPunto3)
        {
            this.iPunto1 = pPunto1;
            this.iPunto2 = pPunto2;
            this.iPunto3 = pPunto3;
        }

        // Propiedades
        public Punto Punto1
        {
            get { return this.iPunto1; }
        }

        public Punto Punto2
        {
            get { return this.iPunto2; }
        }

        public Punto Punto3
        {
            get { return this.iPunto3; }
        }
        //Calculo los lados con las distancias entre cada punto.
        private double Lado1
        {
            get { return iPunto1.CalcularDistanciaDesde(iPunto2); }
        }

        private double Lado2
        {
            get { return iPunto2.CalcularDistanciaDesde(iPunto3); }
        }

        private double Lado3
        {
            get { return iPunto3.CalcularDistanciaDesde(iPunto1); }
        }

        //Calculo el área con la fórmula de Herón.
        public double Area
        {
            get
            {
                double aux = this.Perimetro / 2;
                return Math.Sqrt(aux * (aux - Lado1) * (aux - Lado2) * (aux - Lado3));
            }
        }

        //Calculo el perimetro usando los lados calculados anteriormente.
        public double Perimetro
        {
            get { return Lado1 + Lado2 + Lado3; }
        }

    }
}
