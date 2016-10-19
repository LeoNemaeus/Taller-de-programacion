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
            //UNDONE crear solicitudes con distintos clientes
            //TODO armar arreglo con las sollicitudes
            IList<SolicitudPrestamo> SolicitudesValidas = new List<SolicitudPrestamo>();
            IList<SolicitudPrestamo> SolicitudesInvalidas = new List<SolicitudPrestamo>();

            //Weas válidas
            SolicitudesValidas.Add(armarSolicitud("Ned", "Ludd", new DateTime(1988, 05, 12), 6500, new DateTime(2005, 02, 12), 3000, 6, TipoCliente.NoCliente));
            SolicitudesValidas.Add(armarSolicitud("Ned", "Ludd", new DateTime(1988, 05, 12), 6500, new DateTime(2005, 02, 12), 3000, 6, TipoCliente.Cliente));
            SolicitudesValidas.Add(armarSolicitud("Ned", "Ludd", new DateTime(1988, 05, 12), 6500, new DateTime(2005, 02, 12), 3000, 6, TipoCliente.ClienteGold));
            SolicitudesValidas.Add(armarSolicitud("Ned", "Ludd", new DateTime(1988, 05, 12), 6500, new DateTime(2005, 02, 12), 3000, 6, TipoCliente.ClientePremium));
            SolicitudesValidas.Add(armarSolicitud("Ned", "Ludd", new DateTime(1988, 05, 12), 6500, new DateTime(2005, 02, 12), 3000, 6, TipoCliente.NoCliente));

            //Weas no válidas
            SolicitudesInvalidas.Add(armarSolicitud("Ned", "Ludd", new DateTime(2005, 05, 12), 6500, new DateTime(2005, 02, 12), 3000, 6, TipoCliente.NoCliente));
            SolicitudesInvalidas.Add(armarSolicitud("Ned", "Ludd", new DateTime(1988, 05, 12), 1500, new DateTime(2005, 02, 12), 3000, 6, TipoCliente.NoCliente));
            SolicitudesValidas.Add(armarSolicitud("Ned", "Ludd", new DateTime(1988, 05, 12), 6500, new DateTime(2016, 05, 12), 3000, 6, TipoCliente.NoCliente));
            SolicitudesValidas.Add(armarSolicitud("Ned", "Ludd", new DateTime(1988, 05, 12), 6500, new DateTime(2005, 02, 12), 25000, 6, TipoCliente.NoCliente));
            SolicitudesValidas.Add(armarSolicitud("Ned", "Ludd", new DateTime(1988, 05, 12), 6500, new DateTime(2005, 02, 12), 3000, 32, TipoCliente.NoCliente));
            SolicitudesValidas.Add(armarSolicitud("Ned", "Ludd", new DateTime(1988, 05, 12), 6500, new DateTime(2005, 02, 12), 150000, 6, TipoCliente.Cliente));
            SolicitudesValidas.Add(armarSolicitud("Ned", "Ludd", new DateTime(1988, 05, 12), 6500, new DateTime(2005, 02, 12), 3000, 100, TipoCliente.NoCliente));
            SolicitudesValidas.Add(armarSolicitud("Ned", "Ludd", new DateTime(1988, 05, 12), 6500, new DateTime(2005, 02, 12), 3000, 6, TipoCliente.Cliente));


            foreach (var solicitud in SolicitudesValidas)
            {
                Assert.IsTrue(iGestor.EsValida(solicitud));
            }

            foreach (var solicitud in SolicitudesInvalidas)
            {
                Assert.IsFalse(iGestor.EsValida(solicitud));
            }


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