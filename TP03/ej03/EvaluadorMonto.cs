using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej03
{
    //TODO: implementar EsVálida() en EvaluadorMonto
    public class EvaluadorMonto : IEvaluador
    {
        double iMontoMaximo;

        public EvaluadorMonto(double pMontoMaximo)
        {
            iMontoMaximo = pMontoMaximo;
        }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        { }
    }
}
