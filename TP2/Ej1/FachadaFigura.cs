using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    class FachadaFigura
    {   //m variables de metodo, p parametros, i instancia, b bloque
        //Crear un punto a partir de dos coordenadas
        // Las operaciones deben ser atómicas en fachada.
        private Punto CrearPunto(double pX, double pY)
        {
            Punto iPunto = new Punto(pX, pY);
            return iPunto;
        }

        //Calculo del area del circulo ingresando dos puntos y el radio
        public double CalcularAreaCirculo(double pX, double pY, double pRadio)
        {
            Punto cPunto = new Punto(pX, pY);
            Circulo iCirculo = new Circulo(pX, pY, pRadio);
            return iCirculo.Area;
        }
        //Calculo del perimetro del circulo ingresando dos puntos y el radio
        public double CalcularPerimetroCirculo(double pX, double pY, double pRadio)
        {
            Circulo iCirculo = new Circulo(pX, pY, pRadio);
            return iCirculo.Perimetro;
        }
        /*Calculo del area del circulo ingresando un centro y el radio
        public double CalcularAreaCirculo(Punto pC, double pRadio)
        {
            Circulo iCirculo = new Circulo(pC, pRadio);
            return iCirculo.Area;
        }
        
        Calculo del perimetro del circulo ingresando un centro y el radio
        public double CalcularPerimetroCirculo(Punto pC, double pRadio)
        {
            Circulo iCirculo = new Circulo(pC, pRadio);
            return iCirculo.Perimetro;
        }
        */
        //Calculo del Area del triangulo ingresando tres puntos.
        public double CalcularAreaTriangulo(double px1, double py1, double px2, double py2, double px3, double py3)
        {
            Punto mPunto1 = new Punto(px1, py1);
            Punto mPunto2 = new Punto(px2, py2);
            Punto mPunto3 = new Punto(px3, py3);
            Triangulo iTriangulo = new Triangulo(mPunto1, mPunto2, mPunto3);
            return iTriangulo.Area;
        }
        //Calculo del perimetro del triangulo ingresando tres puntos.
        public double CalcularPerimetroTriangulo(double px1, double py1, double px2, double py2, double px3, double py3)
        {
            Punto mPunto1 = new Punto(px1, py1);
            Punto mPunto2 = new Punto(px2, py2);
            Punto mPunto3 = new Punto(px3, py3);
            Triangulo iTriangulo = new Triangulo(mPunto1,mPunto2,mPunto3);
            return iTriangulo.Perimetro;
        }

        internal void CrearPunto(double v, object pxc1, object px)
        {
            throw new NotImplementedException();
        }
    }
}
