using Microsoft.VisualStudio.TestTools.UnitTesting;
using ej03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej03.Tests
{
    [TestClass()]
    public class GestorPrestamosTests
    {
        GestorPrestamos iGestor;
        [TestMethod()]
        public void GestorPrestamosTest()
        {
            iGestor = new GestorPrestamos();
            Assert.IsNotNull(iGestor);
        }

        [TestMethod()]
        public void EsValidaTest()
        {
            //UNDONE crear solicitudes con distintos clientes.
            SolicitudPrestamo mSolicitud1 = armarSolicitud("Ned", "Lud", new DateTime(1988, 05, 12), 6500, new DateTime(2005, 02, 12), 3000, 6, TipoCliente.Cliente);
            SolicitudPrestamo mSolicitud2 = armarSolicitud("Pablo", "Escobar", new DateTime(1957, 08, 24), 20000, new DateTime(2000, 07, 29), 5000, 12, TipoCliente.ClienteGold);
            SolicitudPrestamo mSolicitud3 = armarSolicitud("Puto", "El que lee", new DateTime(2000, 03, 24), )

            Assert.IsTrue(iGestor.EsValida(mSolicitud1));


        }

        private SolicitudPrestamo armarSolicitud(string pNombre, string pApellido, DateTime pFechaNacimiento, double pSueldo, DateTime pFechaIngreso, double pMonto, int pCuotas, TipoCliente pTipoCliente)
        {
            Empleo mEmpleo = new Empleo(pSueldo, pFechaIngreso);
            Cliente mCliente = new Cliente(pNombre, pApellido, pFechaNacimiento, mEmpleo, pTipoCliente);
            SolicitudPrestamo mSolicitud = new SolicitudPrestamo(mCliente, pMonto, pCuotas);

            return mSolicitud;
        }
    }
}