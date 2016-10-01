using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ej04;


namespace ComplejoTest
{
    [TestClass]
    public class ComplejoTest
    {
        [TestMethod]
        public void UnConjugado()
        {
            Complejo unComplejo = new Complejo(2, 3);
            Complejo ResultadoEsperado = new Complejo(2, -3);
            Complejo Resultado;
            Resultado = unComplejo.Conjugado;
            
            Assert.AreEqual(ResultadoEsperado.Real, Resultado.Real);
            Assert.AreEqual(ResultadoEsperado.Imaginario, Resultado.Imaginario);
        }

        [TestMethod]
        public void SumarComplejos()
        {
            Complejo unComplejo = new Complejo(2, 3);
            Complejo otroComplejo = new Complejo(3, 1);
            Complejo ResultadoEsperado = new Complejo(5, 4);
            Complejo Resultado;
            Resultado = unComplejo.Sumar(otroComplejo);
            
            Assert.AreEqual(ResultadoEsperado.Real, Resultado.Real);
            Assert.AreEqual(ResultadoEsperado.Imaginario, Resultado.Imaginario);
        }

        [TestMethod]
        public void RestarComplejos()
        {
            Complejo unComplejo = new Complejo(5, 3);
            Complejo otroComplejo = new Complejo(3, 1);
            Complejo ResultadoEsperado = new Complejo(2, 2);
            Complejo Resultado;
            Resultado = unComplejo.Restar(otroComplejo);

            Assert.AreEqual(ResultadoEsperado.Real, Resultado.Real);
            Assert.AreEqual(ResultadoEsperado.Imaginario, Resultado.Imaginario);
        }

        [TestMethod]
        public void MultiplicarComplejos()
        {
            Complejo unComplejo = new Complejo(2, 3);
            Complejo otroComplejo = new Complejo(2, 1);
            Complejo ResultadoEsperado = new Complejo(1, 8);
            Complejo Resultado;
            Resultado = unComplejo.MultiplicarPor(otroComplejo);

            Assert.AreEqual(ResultadoEsperado.Real, Resultado.Real);
            Assert.AreEqual(ResultadoEsperado.Imaginario, Resultado.Imaginario);
        }

        [TestMethod]
        public void DividirComplejos()
        {
            Complejo unComplejo = new Complejo(2, 3);
            Complejo otroComplejo = new Complejo(3, 1);
            Complejo ResultadoEsperado = new Complejo(0.9,0.7);
            Complejo Resultado;
            Resultado = unComplejo.DividirPor(otroComplejo);

            Assert.AreEqual(ResultadoEsperado.Real, Resultado.Real);
            Assert.AreEqual(ResultadoEsperado.Imaginario, Resultado.Imaginario);
        }
    }
}
