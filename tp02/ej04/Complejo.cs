using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej04
{
    /// <summary>
    /// La clase <c>Complejo</c> hace referencia a los números complejos de la forma z = a + bi.
    /// </summary>
    public class Complejo
    {
        private readonly double iReal, iImaginario;
        /// <summary>
        /// Una instancia de la clase <c>Complejo</c> se construye con parametros <paramref name="pReal"/> y <paramref name="pImaginario"/>.
        /// </summary>
        /// <param name="pReal">Elemento de tipo real que existe en un número complejo</param>
        /// <param name="pImaginario">Elemento de tipo imaginario que existe en un número complejo</param>
        public Complejo(double pReal, double pImaginario)
        {
            this.iReal = pReal;
            this.iImaginario = pImaginario;
        }
        public  double Real
        {
            get { return this.iReal; }
        }
        public double Imaginario
        {
            get { return this.iImaginario; }
        }
        /// <summary>
        /// La fase en radianes del número complejo.
        /// </summary>
          public double ArgumentoEnRadianes
        {
            get { return ((Math.Atan(this.Imaginario / this.Real) * (Math.PI/ 180))); } 
        }
        
        /// <summary>
        /// La fase en grados del número complejo.
        /// </summary>
        public double ArgumentoEnGrados
        {
            get { return ((Math.Atan(this.Imaginario / this.Real) * (180/Math.PI))); } 
        }
        
        /// <summary>
        /// Componente real que indica la longitud vectorial del número complejo. 
        /// </summary>
        public double Magnitud
        {
            get { return Math.Sqrt(Math.Pow(this.Real, 2) + Math.Pow(this.Imaginario, 2)); }
        }
        /// <summary>
        /// Se indica si el número complejo es del tipo Real.
        /// </summary>
        /// <returns>true si el componente imaginario es cero, false de lo contrario</returns>
        public bool EsReal
        {
            get {return this.Imaginario == 0;} 
        }
        /// <summary>
        /// Se indica si el número complejo es del tipo Imaginario.
        /// </summary>
        /// <returns>true si el componente real es cero y el componente imaginario nunca es igual a cero, false si no se cumplen las condiciones</returns>
        public bool EsImaginario
        {
            get {return (this.Imaginario != 0 && this.Real == 0);}
        }

        
        /// <summary>
        /// Se evalúa la igualdad entre los números complejos como objetos de la clase <c>Complejo</c>.
        /// </summary>
        /// <param name="pComplejo"> un número complejo</param>
        /// <returns>true si los dos números complejos son iguales, false de lo contrario</returns>
      
        public bool EsIgual(Complejo pComplejo)
        {
            return this == pComplejo;
        }
        /// <summary>
        /// Se evalúa la igualdad entre los componentes de los números complejos de la clase <c>Complejo</c>.
        /// </summary>
        /// <param name="pReal"></param>
        /// <param name="pImaginario"></param>
        /// <returns>true si los componentes de los dos números complejos son iguales, false de lo contrario</returns>
        public bool EsIgual(double pReal, double pImaginario)
        {
            return this.Real == pReal && this.Imaginario == pImaginario;
        }


        /// <summary>
        /// El conjugado de un número complejo "z" invierte el signo de su parte imaginaria.
        /// <example>Si z=a+bi es complejo, su conjugado es w= a-bi</example>
        /// </summary>
        /// <param name="pComplejo"></param>
        /// <returns>Devuelve una nueva instancia de la clase <c>Complejo</c>, complemento de la instancia original.</returns>
        public Complejo Conjugado
        {
            get {return (new Complejo (this.Real, - this.Imaginario));}
        }
        /// <summary>
        /// La suma de dos números complejos.
        /// </summary>
        /// <param name="pComplejo"></param>
        /// <returns>Devuelve una nueva instancia de la clase <c>Complejo</c>, resultado de la suma de <para>pComplejo</para> y la instancia que responde al método.</returns>
        public Complejo Sumar(Complejo pComplejo)
        {
            return (new Complejo(this.Real + pComplejo.Real, this.Imaginario + pComplejo.Imaginario));
        }
        /// <summary>
        /// La resta de dos números complejos.
        /// </summary>
        /// <param name="pComplejo"></param>
        /// <returns>Devuelve una nueva instancia de la clase <c>Complejo</c>, resultado de la resta de <para>pComplejo</para> y la instancia que responde al método.</returns>
        public Complejo Restar(Complejo pComplejo)
        {
            return (new Complejo(this.Real - pComplejo.Real, this.Imaginario - pComplejo.Imaginario));
        }
        /// <summary>
        /// La multiplicación de dos números complejos.
        /// </summary>
        /// <param name="pComplejo"></param>
        /// <returns>Devuelve una nueva instancia de la clase <c>Complejo</c>.</returns>
        public Complejo MultiplicarPor(Complejo pComplejo)
        {
            return
                new Complejo
                (
                ((this.Real * pComplejo.Real) - (this.Imaginario * pComplejo.Imaginario)),
                ((this.Real * pComplejo.Imaginario) + (this.Imaginario * pComplejo.Real))
                );
        }
        /// <summary>
        /// La división de dos números complejos.
        /// </summary>
        /// <param name="pComplejo"></param>
        /// <returns>Devuelve una nueva instancia de la clase <c>Complejo</c>.</returns>
        public Complejo DividirPor(Complejo pComplejo)
        {
            return new Complejo
                (
                ((this.Real * pComplejo.Real) + (this.Imaginario * pComplejo.Imaginario))/(Math.Pow(pComplejo.Real,2)+Math.Pow(pComplejo.Imaginario,2)),
                ((this.Imaginario * pComplejo.Real)-(this.Real * pComplejo.Imaginario))/(Math.Pow(pComplejo.Real,2)+Math.Pow(pComplejo.Imaginario,2))
                );
        }
    }
}
