using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{   //m variables de metodo, p parametros, i instancia, b bloque, c variable de clase
    class Circulo
    {   // Atributos de la clase
        private double iRadio; 
        private Punto iCentro;

        //Constructores
        public Circulo(Punto pCentro, double pRadio)
        {
            this.iCentro = pCentro;
            this.iRadio = pRadio;
        }

        public Circulo(double pX, double pY, double pRadio)
        {
            this.iCentro = new Punto (pX,pY);
            this.iRadio = pRadio;
        }

        // Propiedades
        public Punto Centro
        {
            get {return this.iCentro; }
        }

        public double Radio
        {
            get { return this.iRadio; }
        }
        //Calculo el área dentro de la propiedad...
        public double Area
        {
            get { return iRadio * Math.Pow(Math.PI, 2); }
        }
        //Calculo el perímetro dentro de la propiedad...
        public double Perimetro
        {
            get { return iRadio * 2 * Math.PI; }
        }
    }
}
