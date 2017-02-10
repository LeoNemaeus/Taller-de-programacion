using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej02
{
    public class Matematica
    {
        public static double Dividir(int pDividendo, int pDivisor)
        {
            if (pDivisor == 0)
            {
                throw new DivisionPorCeroException("La división por cero es inválida. ");
            }
            return (pDividendo / pDivisor);
        }
    }
}
