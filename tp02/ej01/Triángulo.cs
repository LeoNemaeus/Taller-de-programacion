using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    // clase triangulo
    class Triángulo
    {
        // vertices, su orden es indistinto
        private Punto iPunto1, iPunto2, iPunto3;

        // constructor: Triangulo(vertice 1, vertice 2, vertice 3)
        // los vertices tienen que ser objetos de clase Punto
        public Triángulo(Punto pPunto1, Punto pPunto2, Punto pPunto3)
        {
            iPunto1 = pPunto1;
            iPunto2 = pPunto2;
            iPunto3 = pPunto3;
        }

        // devuelve el objeto de clase Punto que representa las coordenadas del vertice 1
        public Punto Punto1
        {
            get { return iPunto1; }
        }

        // devuelve el objeto de clase Punto que representa las coordenadas del vertice 2
        public Punto Punto2
        {
            get { return iPunto2; }
        }

        // devuelve el objeto de clase Punto que representa las coordenadas del vertice 3
        public Punto Punto3
        {
            get { return iPunto3; }
        }

        // l1, l2 y l3 son accesores que representan los lados del triangulo, estan para
        // mayor claridad en el codigo.
        // l1: lado que va desde el punto 1 al punto 2
        // l2: lado que va desde el punto 1 al punto 3
        // l3: lado que va desde el punto 2 al punto 3
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

        // devuelve un double equivalente al area del triangulo, usa la Formula de Heron
        public double Área
        {
            get
            {
                double s = this.Perímetro / 2;
                return (Math.Sqrt(s*(s - this.l1)*(s - this.l2)*(s - this.l3)));
            }
        }

        // devuelve un double equivalente a la suma de los tres lados
        public double Perímetro
        {
            get { return (this.l1 + this.l2 + this.l3); }
        }
    }
}
