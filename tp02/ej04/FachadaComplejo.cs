using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4
{
    class FachadaComplejo
    {
      
        public bool AnalizarReal (double pReal, double pImaginario)
        {
            Complejo iComplejo = new Complejo (pReal, pImaginario);
            return iComplejo.EsReal;
        }

        public bool AnalizarImaginario (double pReal, double pImaginario)
        {
            Complejo iComplejo = new Complejo(pReal, pImaginario);
            return iComplejo.EsImaginario;
        }

        public bool Comparar (double pReal, double pImaginario, double pReal2, double pImaginario2)
        {
            Complejo iComplejo = new Complejo(pReal, pImaginario);
            Complejo iComplejo2 = new Complejo (pReal2, pImaginario2);
            return iComplejo.EsIgual(iComplejo2);
        }

        public bool Comparar (double pReal, double pImaginario, double pReal2, double pImaginario2)
        {
            Complejo iComplejo = new Complejo(pReal, pImaginario);
            return iComplejo.EsIgual(pReal2,pImaginario2);
        }

        public Complejo CalcularConjugado (double pReal, double pImaginario)
        {
            Complejo iComplejo = new Complejo(pReal, pImaginario);
            return iComplejo.Conjugado;
        }

        public Complejo SumarComplejos(double pReal, double pImaginario, double pR, double pIm)
        {
            Complejo iComplSumar = new Complejo(pR, pIm);
            return iComplejo.Sumar(iComplSumar);
        }
   
     

    }
}  
        
