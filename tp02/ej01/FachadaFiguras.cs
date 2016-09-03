using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej01
{
    class FachadaFiguras
    {
        public double CalcularÁreaCírculo(double pX, double pY, double pRadio)
        {
            Círculo mCírculo = new ej01.Círculo(pX, pY, pRadio);
            return mCírculo.Área;
        }
        public double CalcularPerímetroCírculo(double pX, double pY,
                                               double pRadio)
        {
            Círculo mCírculo = new ej01.Círculo(pX, pY, pRadio);
            return mCírculo.Perímetro;
        }
        public double CalcularÁreaTriángulo(double pX1, double pY1,
                                            double pX2, double pY2,
                                            double pX3, double pY3)
        {
            Punto p1 = new Punto(pX1, pY1);
            Punto p2 = new Punto(pX2, pY2);
            Punto p3 = new Punto(pX3, pY3);
            Triángulo mTriángulo = new Triángulo(p1, p2, p3);
            return mTriángulo.Área;
        }
        public double CalcularPerímetroTriángulo(double pX1, double pY1,
                                                 double pX2, double pY2,
                                                 double pX3, double pY3)
        {
            Punto p1 = new Punto(pX1, pY1);
            Punto p2 = new Punto(pX2, pY2);
            Punto p3 = new Punto(pX3, pY3);
            Triángulo mTriángulo = new Triángulo(p1, p2, p3);
            return mTriángulo.Perímetro;
        }
    }
}


