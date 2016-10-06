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
            iOtraFecha = new Fechas(15, 12, 1945);
            Fechas mResultado = iUnaFecha.AgregarDias(1);

            Assert.AreEqual(iOtraFecha.DiaDeLaSemana, mResultado.DiaDeLaSemana);
            Assert.AreEqual(iOtraFecha.Dia, mResultado.Dia);
            Assert.AreEqual(iOtraFecha.Mes, mResultado.Mes);
            Assert.AreEqual(iOtraFecha.Año, mResultado.Año);

        }

        /// <summary>
        /// Test de AgregarMeses. Compara día, mes y año
        /// </summary>
        [TestMethod()]
        public void AgregarMesesTest()
        {
            iOtraFecha = new Fechas(14, 08, 1947);
            Fechas mResultado = iUnaFecha.AgregarMeses(20);

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
            iOtraFecha = (new Fechas(14, 12, 1965));
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

        [TestMethod]
        public void CompararFechaTest()
        {
            int mResultado = iUnaFecha.CompararFecha(new Fechas(4, 11, 2021));
            Assert.AreEqual(-1, mResultado);

            mResultado = iUnaFecha.CompararFecha(new Fechas(14, 12, 1945));
            Assert.AreEqual(0, mResultado);

            mResultado = iUnaFecha.CompararFecha(new Fechas(14, 12, 1943));
            Assert.AreEqual(1, mResultado);
        }
    }
}
