using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej03
{
    public class GestorPrestamos
    {
        //TODO: no entiendo nada de GestorPrestamos.
        IDictionary<TipoCliente, IEvaluador> iEvaluadoresPorCliente = new Dictionary<TipoCliente, IEvaluador>();

        public GestorPrestamos()
        { }

        public Boolean EsValida(SolicitudPrestamo pSolicitud)
        { }
    }
}
