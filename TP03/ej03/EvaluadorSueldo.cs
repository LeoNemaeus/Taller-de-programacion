using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej03
{
    //TODO: implementar EsVálida() en EvaluadorSueldo
    public class EvaluadorSueldo : IEvaluador
    {
        double iSueldoMinimo;

        public EvaluadorSueldo(double pSueldoMinimo)
        {
            iSueldoMinimo = pSueldoMinimo;
        }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        { }
    }
}
