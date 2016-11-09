using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//UNDONE fachada Prestamos: debería 
//TODO documentar Prestamos.

namespace ej03
{
    class Prestamos
    {
        public bool evaluarSolicitud(string pNombre, string pApellido, DateTime pFechaNacimiento, double pSueldo, DateTime pFechaIngreso, double pMonto, int pCuotas, string pTipoCliente)
        {
            TipoCliente mTipoCliente;
            GestorPrestamos mGestor = new GestorPrestamos();

            switch (pTipoCliente.ToLower())
            {
                case "nocliente":
                    mTipoCliente = TipoCliente.NoCliente;
                    break;
                case "cliente":
                    mTipoCliente = TipoCliente.Cliente;
                    break;
                case "clientegold":
                    mTipoCliente = TipoCliente.ClienteGold;
                        break;
                case "clientepremium":
                    mTipoCliente = TipoCliente.ClientePremium;
                    break;
                default:
                    if (pTipoCliente == "")
                    {
                        mTipoCliente = TipoCliente.NoCliente;
                    } else
                    {
                        return false;
                    }
                    break;
            }

            Empleo mEmpleo = new Empleo(pSueldo, pFechaIngreso);
            Cliente mCliente = new Cliente(pNombre, pApellido, pFechaNacimiento, mEmpleo, mTipoCliente);
            SolicitudPrestamo mSolicitud = new SolicitudPrestamo(mCliente, pMonto, pCuotas);

            return mGestor.EsValida(mSolicitud);
        }
    }
}
