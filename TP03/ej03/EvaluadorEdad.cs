using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej03
{
    //TODO: implementar EsVálida() en EvaluadorEdad
    public class EvaluadorEdad : IEvaluador
    {
        int iEdadMinima, iEdadMaxima;

        public EvaluadorEdad(int pEdadMinima, int pEdadMaxima)
        {
            iEdadMinima = pEdadMinima;
            iEdadMaxima = pEdadMaxima;
        }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        { }
    }
}
