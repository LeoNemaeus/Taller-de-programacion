using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej03
{
    //TODO: implementar EsVálida() en EvaluadorMonto
    public class EvaluadorCantidadCuotas : IEvaluador
    {
        int iCantidadMaximaCuotas;

        public EvaluadorCantidadCuotas(int pCantidadMaxima)
        {
            iCantidadMaximaCuotas = pCantidadMaxima;
        }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            base.EsValida();


        }
    }
}
