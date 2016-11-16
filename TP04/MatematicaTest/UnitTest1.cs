using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ej02;

namespace MatematicaTest
{
    [TestClass]
    public class MatematicaTest
    {
        [TestMethod]
        public void TestDividir1()
        {
            int mDividendo = 50;
            int mDivisor = 10;
            double mResultadoEsperado = 5;
            double mResultado;

            mResultado = Matematica.Dividir(mDividendo, mDivisor);
            Assert.AreEqual(mResultadoEsperado, mResultado);
          
        }
    }
}
