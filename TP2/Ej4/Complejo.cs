using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// La clase <c>Complejo</c> hace referencia a los números complejos de la forma z = a + bi.
/// </summary>

namespace Ej4
{
    /// <summary>
    /// Se define el tipo struct para la clase <c>Complejo<c/>.
    /// </summary>
    public struct Complejo 
///</summary>
///
///</summaryZ>
    { // Atributos de la clase
        private double iReal;
        private double iImaginario;
        private const double iPi = Math.PI;


        // Constructores de la clase
        internal Complejo(double pReal, double pImaginario)
        {
            this.iReal = pReal;
            this.iImaginario = pImaginario;
        }

        // Propiedades de la clase

        public double Real
        {
            get { return this.iReal; }
        }

        public double Imaginario
        {
            get { return this.iImaginario; }
        }

        public double ArgumentoEnRadianes
        {
            get { return (Math.Atan(this.Imaginario / this.Real)) * (iPi / 180); }
        }

        public double ArgumentoEnGrados

        {
            get { return (Math.Atan(this.Imaginario / this.Real)) * (180 / iPi); }
        }

        public Complejo Conjugado
        { 
            get { return (new Complejo (this.Real, - this.Imaginario)); }
        }
        public double Magnitud
        {   
            get { return (Math.Abs(iReal) + Math.Abs(iImaginario)); }
        }

        public 
            // Metodos
}
}
