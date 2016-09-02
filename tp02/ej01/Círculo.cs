using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    // clase circulo
    class Círculo
    {
        // el punto que representa el centro del circulo, de tipo Punto
        private Punto iCentro;
        // el radio del circulo, de tipo double
        private double iRadio;

        // constructor: Circulo(centro, radio)
        // centro tiene que ser de clase Punto, representa el Punto del centro
        // del circulo
        // radio tiene que ser de tipo double y representa el radio del circulo
        public Círculo(Punto pCentro, double pRadio)
        {
            iCentro = pCentro;
            iRadio = pRadio;
        }

        // constructor: Circulo(x, y, radio)
        // x e y son de tipo double y representan las coordenadas x e y del Punto
        // del centro del circulo
        // radio tiene que ser de tipo double y representa el radio del circulo
        public Círculo(double pX, double pY, double pRadio)
        {
            iCentro = new ejercicio1.Punto(pX, pY);
            iRadio = pRadio;
        }

        // propiedad que devuelve un Punto que representa el centro del circulo
        public Punto Centro
        {
            get
            { return iCentro; }
        }

        // propiedad que devuelve un double que representa la distancia desde el centro
        // a un borde del circulo
        public double Radio
        {
            get { return iRadio; }
        }

        // propiedad que devuelve un double equivalente al area del circulo
        // formula: pi*radio^2
        public double Área
        {
            get { return (Math.PI * Math.Pow(iRadio, 2)); }
        }

        // propiedad que devuelve un double equivalente al perimetro del circulo
        // formula: 2*pi*radio
        public double Perímetro
        {
            get { return (iRadio * 2 * Math.PI); }
        }
    }
}
