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
        /// <summary>
        /// Prueba la creación de iGestor.
        /// </summary>
        GestorPrestamos iGestor;
        [TestMethod()]
        public void GestorPrestamosTest()
        {
            iGestor = new GestorPrestamos();
            Assert.IsNotNull(iGestor);
        }

        /// <summary>
        /// Prueba que se valide adecuadamente cada tipo de cliente.
        /// </summary>
        [TestMethod()]
        public void EsValidaTest()
        {
            iGestor = new GestorPrestamos();
            IList<SolicitudPrestamo> Solicitudes = new List<SolicitudPrestamo>();

            Solicitudes.Add(armarSolicitud("Ned", "Ludd", new DateTime(1988, 05, 12), 5000, new DateTime(2005, 02, 12), 20000, 12, TipoCliente.NoCliente));
            Solicitudes.Add(armarSolicitud("Ned", "Ludd", new DateTime(1988, 05, 12), 6500, new DateTime(2005, 02, 12), 100000, 32, TipoCliente.Cliente));
            Solicitudes.Add(armarSolicitud("Ned", "Ludd", new DateTime(1988, 05, 12), 6500, new DateTime(2005, 02, 12), 150000, 60, TipoCliente.ClienteGold));
            Solicitudes.Add(armarSolicitud("Ned", "Ludd", new DateTime(1988, 05, 12), 6500, new DateTime(2005, 02, 12), 200000, 60, TipoCliente.ClientePremium));

            foreach (SolicitudPrestamo solicitud in Solicitudes) {
                Console.WriteLine("Cliente: {0}, {1}", solicitud.Cliente.FechaNacimiento, solicitud.Cliente.TipoCliente);
                Console.WriteLine("Empleo: {0}; {1}", solicitud.Cliente.Empleo.Sueldo, solicitud.Cliente.Empleo.FechaIngreso);
                Console.WriteLine("Solicitud: {0}; {1}", solicitud.Monto, solicitud.CantidadCuotas);
                Assert.IsTrue(iGestor.EsValida(solicitud));
            }

        }

        /// <summary>
        /// Helper para crear solicitudes.
        /// </summary>
        /// <param name="pNombre"></param>
        /// <param name="pApellido"></param>
        /// <param name="pFechaNacimiento"></param>
        /// <param name="pSueldo"></param>
        /// <param name="pFechaIngreso"></param>
        /// <param name="pMonto"></param>
        /// <param name="pCuotas"></param>
        /// <param name="pTipoCliente"></param>
        /// <returns></returns>
        private SolicitudPrestamo armarSolicitud(string pNombre, string pApellido, DateTime pFechaNacimiento, double pSueldo, DateTime pFechaIngreso, double pMonto, int pCuotas, TipoCliente pTipoCliente)
        {
            Empleo mEmpleo = new Empleo(pSueldo, pFechaIngreso);
            Cliente mCliente = new Cliente(pNombre, pApellido, pFechaNacimiento, mEmpleo, pTipoCliente);
            SolicitudPrestamo mSolicitud = new SolicitudPrestamo(mCliente, pMonto, pCuotas);

            return mSolicitud;
        }
    }
}