using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej03
{
    //TODO: testear EsVálida() en EvaluadorAntiguedadLaboral
    public class EvaluadorAntiguedadLaboral : IEvaluador
    {
        int iAntiguedadMinima;

        public EvaluadorAntiguedadLaboral(int pAntiguedadMinima)
        {
            iAntiguedadMinima = pAntiguedadMinima;
        }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            /*Calcula la difernecia entre la fecha actual y la fecha de ingreso
             * en el empleo, resultando la resta positiva si la antigüedad es
             * superior a la mínima
             */
            TimeSpan mAntiguedad = DateTime.Today - pSolicitud.Cliente.Empleo.FechaIngreso.AddMonths(-iAntiguedadMinima);
            if (mAntiguedad.Seconds >= 0)
                return true;

            return false;
        }
    }
}
