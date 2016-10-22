using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej03
{
    public class GestorPrestamos
    {
        IDictionary<TipoCliente, IEvaluador> iEvaluadoresPorCliente = new Dictionary<TipoCliente, IEvaluador>();

        //TODO remover código redundante para cargar el diccionario.
        public GestorPrestamos()
        {
            EvaluadorCompuesto mEvaluador;
            IEvaluador mEvaluadorSueldo = new EvaluadorSueldo(5000);
            IEvaluador mEvaluadorEdad = new EvaluadorEdad(18, 75);
            IEvaluador mEvaluadorAntiguedadLaboral = new EvaluadorAntiguedadLaboral(6);

            //Evaluadores para un No Cliente
            mEvaluador = new EvaluadorCompuesto();
            mEvaluador.AgregarEvaluador(mEvaluadorSueldo);
            mEvaluador.AgregarEvaluador(mEvaluadorEdad);
            mEvaluador.AgregarEvaluador(mEvaluadorAntiguedadLaboral);
            mEvaluador.AgregarEvaluador(new EvaluadorMonto(20000));
            mEvaluador.AgregarEvaluador(new EvaluadorCantidadCuotas(12));

            iEvaluadoresPorCliente.Add(TipoCliente.NoCliente, mEvaluador);

            //Evaluadores para un Cliente
            mEvaluador = new EvaluadorCompuesto();
            mEvaluador.AgregarEvaluador(mEvaluadorSueldo);
            mEvaluador.AgregarEvaluador(mEvaluadorEdad);
            mEvaluador.AgregarEvaluador(mEvaluadorAntiguedadLaboral);
            mEvaluador.AgregarEvaluador(new EvaluadorMonto(100000));
            mEvaluador.AgregarEvaluador(new EvaluadorCantidadCuotas(32));

            iEvaluadoresPorCliente.Add(TipoCliente.Cliente, mEvaluador);

            //Evaluadores para un Cliente Gold
            mEvaluador = new EvaluadorCompuesto();
            mEvaluador.AgregarEvaluador(mEvaluadorSueldo);
            mEvaluador.AgregarEvaluador(mEvaluadorEdad);
            mEvaluador.AgregarEvaluador(mEvaluadorAntiguedadLaboral);
            mEvaluador.AgregarEvaluador(new EvaluadorMonto(150000));
            mEvaluador.AgregarEvaluador(new EvaluadorCantidadCuotas(60));

            iEvaluadoresPorCliente.Add(TipoCliente.ClienteGold, mEvaluador);

            //Evaluadores para un Cliente Premium
            mEvaluador = new EvaluadorCompuesto();
            mEvaluador.AgregarEvaluador(mEvaluadorSueldo);
            mEvaluador.AgregarEvaluador(mEvaluadorEdad);
            mEvaluador.AgregarEvaluador(mEvaluadorAntiguedadLaboral);
            mEvaluador.AgregarEvaluador(new EvaluadorMonto(200000));
            mEvaluador.AgregarEvaluador(new EvaluadorCantidadCuotas(60));

            iEvaluadoresPorCliente.Add(TipoCliente.ClientePremium, mEvaluador);
        }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            bool mEsValida = false;

            if (iEvaluadoresPorCliente.ContainsKey(pSolicitud.Cliente.TipoCliente))
            {
                mEsValida = iEvaluadoresPorCliente[pSolicitud.Cliente.TipoCliente].EsValida(pSolicitud);
            }

            return mEsValida;
        }
    }
}
