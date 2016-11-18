using Microsoft.VisualStudio.TestTools.UnitTesting;
using ej07.patron_filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej07.patron_filter.Tests
{
    [TestClass()]
    public class CriterioAndTests
    {
        [TestMethod()]
        public void CriterioAndTest()
        {
            ICriterio unCriterio = new CriterioFecha(new DateTime(2016, 11, 12));
            ICriterio otroCriterio = new CriterioNombre("Asd");
            ICriterio criterioAnd = new CriterioOr(unCriterio, otroCriterio);

            Assert.IsNotNull(criterioAnd);
        }

        [TestMethod()]
        public void cumpleCriterioTest()
        {
            ICriterio unCriterio = new CriterioFecha(new DateTime(2016, 11, 12));
            ICriterio otroCriterio = new CriterioNombre("Asd");
            ICriterio criterioAnd = new CriterioOr(unCriterio, otroCriterio);

            Evento unEvento = new Evento("Asd", new DateTime(2016, 11, 12), TimeSpan.FromHours(1), Frecuencia.Unico);

            Assert.IsTrue(criterioAnd.cumpleCriterio(unEvento));
        }
    }
}