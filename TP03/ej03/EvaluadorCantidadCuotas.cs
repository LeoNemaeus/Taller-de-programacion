using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej03
{
    /// <summary>
    /// Permite definir el número máxmo de cuotas para un evaluador.
    /// Verifica que una solicitud de préstamo cumpla con el número de cuotas definido por el evaluador.
    /// </summary>
    public class EvaluadorCantidadCuotas : IEvaluador
    {
        int iCantidadMaximaCuotas;

        public EvaluadorCantidadCuotas(int pCantidadMaxima)
        {
            iCantidadMaximaCuotas = pCantidadMaxima;
        }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            if (pSolicitud.CantidadCuotas <= iCantidadMaximaCuotas)
                return true;

            return false;
        }
    }
}
