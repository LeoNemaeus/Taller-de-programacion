using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej03
{
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
            DateTime Edad = Convert.ToDateTime((pSolicitud.Cliente.FechaNacimiento - DateTime.Now));
            if ((Edad.Year >= iEdadMinima) && (Edad.Year <= iEdadMaxima))
            {
                return true;
            }

            return false;
        }
    }
}
