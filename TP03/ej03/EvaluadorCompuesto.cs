using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej03
{
    class EvaluadorCompuesto : IEvaluador
    {
        IList<IEvaluador> iEvaluadores;
        public EvaluadorCompuesto()
        {
            iEvaluadores = new List<IEvaluador>();
        }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            return iEvaluadores.All(evaluador => evaluador.EsValida(pSolicitud));
        }

        public void AgregarEvaluador(IEvaluador pEvaluador)
        {
            iEvaluadores.Add(pEvaluador);
        }
    }
}
