using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej03
{
    /// <summary>
    /// Premite definir el monto máximo que permitirá un evaluador. Valida una solicitud.
    /// </summary>
    public class EvaluadorMonto : IEvaluador
    {
        double iMontoMaximo;

        public EvaluadorMonto(double pMontoMaximo)
        {
            iMontoMaximo = pMontoMaximo;
        }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            if (pSolicitud.Monto <= iMontoMaximo) return true;

            return false;
        }
    }
}
