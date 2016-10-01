using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ej05;

namespace Ej05.Tests
{
    [TestClass()]
    public class FechaTest
    {
        /// <summary>
        /// Objetos de prueba para realizar los tests.
        /// </summary>
        Fechas iUnaFecha = new Fechas(14, 12, 1945);
        Fechas iOtraFecha;

        /// <summary>
        /// Test del constructor
        /// </summary>
        [TestMethod()]
        public void FechasTest()
        {
            Assert.IsNotNull(iUnaFecha);
        }

        /// <summary>
        /// Test de AgregarDias. Compara día, mes, año y el día de la semana
        /// </summary>
        [TestMethod()]
        public void AgregarDiasTest()
        {
            iOtraFecha = new Fechas(25, 02, 2016);
            Fechas mResultado = iUnaFecha.AgregarDias(25640);

            Assert.AreEqual(iOtraFecha.DiaDeLaSemana, mResultado.DiaDeLaSemana);
            Assert.AreEqual(iOtraFecha.Dia, mResultado.Dia);
            Assert.AreEqual(iOtraFecha.Mes, mResultado.Mes);
            Assert.AreEqual(iOtraFecha.Año, mResultado.Año);

        }

        /// <summary>
        /// Test de AgregarMeses. Compara día, mes, año y el día de la semana
        /// </summary>
        [TestMethod()]
        public void AgregarMesesTest()
        {
            iOtraFecha = new Fechas(14, 07, 1947);
            Fechas mResultado = iUnaFecha.AgregarMeses(20);

            Assert.AreEqual(iOtraFecha.DiaDeLaSemana, mResultado.DiaDeLaSemana);
            Assert.AreEqual(iOtraFecha.Dia, mResultado.Dia);
            Assert.AreEqual(iOtraFecha.Mes, mResultado.Mes);
            Assert.AreEqual(iOtraFecha.Año, mResultado.Año);
        }

        /// <summary>
        /// Test de AgregarAños. Compara día, mes, año y el día de la semana
        /// </summary>
        [TestMethod()]
        public void AgregarAñosTest()
        {
            iOtraFecha = new Fechas(14, 12, 1965);
            Fechas mResultado = iUnaFecha.AgregarAños(20);

            Assert.AreEqual(iOtraFecha.DiaDeLaSemana, mResultado.DiaDeLaSemana);
            Assert.AreEqual(iOtraFecha.Dia, mResultado.Dia);
            Assert.AreEqual(iOtraFecha.Mes, mResultado.Mes);
            Assert.AreEqual(iOtraFecha.Año, mResultado.Año);
        }

        /// <summary>
        /// Test de EsBisiesto. Prueba algunos ejemplos de años bisiestos y no bisiestos.
        /// </summary>
        [TestMethod()]
        public void EsBisiestoTest()
        {
            //Bisiestos
            Assert.IsTrue(Fechas.EsBisiesto(2012));
            Assert.IsTrue(Fechas.EsBisiesto(2016));
            
            //No bisiestos
            Assert.IsFalse(Fechas.EsBisiesto(1915));
            Assert.IsFalse(Fechas.EsBisiesto(1905));
        }
    }
}
