using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej03
{
    class EvaluadorCompuesto : IEvaluador
    {
        private readonly IList<IEvaluador> iEvaluadores = new List<IEvaluador>();
        public EvaluadorCompuesto()
        {
        }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            return iEvaluadores.All(evaluador => evaluador.EsValida(pSolicitud));

            /*
             * ALTERNATIVA:
             * 
             * bool esValida = true;
             * IEnumerator<IEvaluator> enumerador = iEvaluadores.GetEnumerator();
             * 
             * while (esValida && enumerador.MoveNext())
             * {
             *  esValida = enumerador.Current.EsValida(pSolicitud);
             * }
             * 
             * return esValida;
             */
        }

        public void AgregarEvaluador(IEvaluador pEvaluador)
        {
            iEvaluadores.Add(pEvaluador);
        }
    }
}
