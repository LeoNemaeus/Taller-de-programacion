using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej03
{
    /// <summary>
    /// Contiene una solicitud de préstamo, conformada por un cliente, monto y cantidad de cuotas.
    /// 
    /// </summary>
    public class SolicitudPrestamo
    {
        double iMonto;
        int iCantidadCuotas;
        Cliente iCliente;
        /// <summary>
        /// Crea una solicitud de préstamo mediante un cliente, monto y cantidad de cuotas
        /// </summary>
        /// <param name="pCliente"></param>
        /// <param name="pMonto"></param>
        /// <param name="pCantidadCuotas"></param>
        public SolicitudPrestamo(Cliente pCliente, double pMonto, int pCantidadCuotas)
        {
            iCliente = pCliente;
            iMonto = pMonto;
            iCantidadCuotas = pCantidadCuotas;
        }

        public double Monto
        { get { return iMonto; } }

        public int CantidadCuotas
        { get { return iCantidadCuotas; } }

        public Cliente Cliente
        { get { return iCliente; } }
    }
}
