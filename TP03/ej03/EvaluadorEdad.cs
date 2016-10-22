using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej03
{
    //TODO: testear EsVálida() en EvaluadorEdad
    public class EvaluadorEdad : IEvaluador
    {
        int iEdadMinima, iEdadMaxima;

        public EvaluadorEdad(int pEdadMinima, int pEdadMaxima)
        {
            iEdadMinima = pEdadMinima;
            iEdadMaxima = pEdadMaxima;
        }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            DateTime mFechaNacimiento = pSolicitud.Cliente.FechaNacimiento;

            DateTime aux1 = DateTime.Today.AddYears(-iEdadMinima);
            DateTime aux2 = DateTime.Today.AddYears(-iEdadMaxima);

            if ((DateTime.Compare(mFechaNacimiento, aux1) <= 0 ) && (DateTime.Compare(mFechaNacimiento, aux2)) >= 0 )
            {
                return true;
            }

            return false;
        }
    }
}
