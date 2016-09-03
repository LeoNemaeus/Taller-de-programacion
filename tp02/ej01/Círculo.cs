using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej01
{
    class Círculo
    {
        private Punto iCentro;
        private double iRadio;

        public Círculo(Punto pCentro, double pRadio)
        {
            iCentro = pCentro;
            iRadio = pRadio;
        }

        public Círculo(double pX, double pY, double pRadio)
        {
            iCentro = new ej01.Punto(pX, pY);
            iRadio = pRadio;
        }

        public Punto Centro
        {
            get
            { return iCentro; }
        }

        public double Radio
        {
            get { return iRadio; }
        }

        //Calcula el área del círculo y la devuelve.
        public double Área
        {
            get { return (Math.PI * Math.Pow(iRadio, 2)); }
        }

        public double Perímetro
        {
            get { return (iRadio * 2 * Math.PI); }
        }
    }
}
