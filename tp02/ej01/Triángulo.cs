using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    class Triángulo
    {
        Punto iPunto1, iPunto2, iPunto3;

        public Triángulo(Punto pPunto1, Punto pPunto2, Punto pPunto3)
        {
            iPunto1 = pPunto1;
            iPunto2 = pPunto2;
            iPunto3 = pPunto3;
        }

        public Punto Punto1
        {
            get { return iPunto1; }
        }

        public Punto Punto2
        {
            get { return iPunto2; }
        }

        public Punto Punto3
        {
            get { return iPunto3; }
        }

        private double l1
        {
            get { return iPunto1.CalcularDistanciaDesde(iPunto2); }
        }

        private double l2
        {
            get { return iPunto1.CalcularDistanciaDesde(iPunto3); }
        }

        private double l3
        {
            get { return iPunto2.CalcularDistanciaDesde(iPunto3); }
        }

        public double Área
        {
            get
            {
                double s = this.Perímetro / 2;
                return (Math.Sqrt(s*(s - this.l1)*(s - this.l2)*(s - this.l3)));
            }
        }

        public double Perímetro
        {
            get { return (this.l1 + this.l2 + this.l3); }
        }
    }
}
