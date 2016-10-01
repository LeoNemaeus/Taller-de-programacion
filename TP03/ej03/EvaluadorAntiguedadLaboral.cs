using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej03
{
    //TODO: implementar EsVálida() en EvaluadorAntiguedadLaboral
    public class EvaluadorAntiguedadLaboral : IEvaluador
    {
        int iAntiguedadMinima

        public EvaluadorAntiguedadLaboral(int pAntiguedadMinima)
        {
            iAntiguedadMinima = pAntiguedadMinima;
        }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        { }
    }
}
