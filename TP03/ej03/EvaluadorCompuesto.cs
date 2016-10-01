using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej03
{
    //TODO: implementar constructor, EsValida().
    class EvaluadorCompuesto
    {
        IList<IEvaluador> iEvaluadores = new List<IEvaluador>();
        public EvaluadorCompuesto()
        { }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        { }

        public void AgregarEvaluador(IEvaluador pEvaluador)
        {
            iEvaluadores.Add(pEvaluador);
        }
    }
}
