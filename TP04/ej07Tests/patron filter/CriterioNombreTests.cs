using Microsoft.VisualStudio.TestTools.UnitTesting;
using ej07.patrón_filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej07.patrón_filter.Tests
{
    [TestClass()]
    public class CriterioNombreTests
    {
        [TestMethod()]
        public void CriterioNombreTest()
        {
            ICriterio unCriterio = new CriterioNombre("Asd");
            Assert.IsNotNull(unCriterio);
        }

        [TestMethod()]
        public void cumpleCriterioTest()
        {
            Evento unEvento = new Evento("Asd", new DateTime(2016, 11, 12), TimeSpan.FromHours(1), Frecuencia.Unico);

            ICriterio criterioVerdadero = new CriterioNombre("Asd");
            ICriterio criterioFalso = new CriterioNombre("qwert");

            Assert.IsTrue(criterioVerdadero.cumpleCriterio(unEvento));
            Assert.IsFalse(criterioFalso.cumpleCriterio(unEvento));
        }
    }
}