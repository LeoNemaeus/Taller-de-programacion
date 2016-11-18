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
    public class CriterioFechaTests
    {
        [TestMethod()]
        public void CriterioFechaTest()
        {
            ICriterio unCriterio = new CriterioFecha(new DateTime(2016, 11, 12), new DateTime(2016, 12, 12));
            Assert.IsNotNull(unCriterio);
        }

        [TestMethod()]
        public void CriterioFechaTest1()
        {
            ICriterio unCriterio = new CriterioFecha(new DateTime(2016, 11, 12));
            Assert.IsNotNull(unCriterio);
        }

        [TestMethod()]
        public void cumpleCriterioTest()
        {
            Evento unEvento = new Evento("", new DateTime(2016, 11, 24), TimeSpan.FromHours(1), Frecuencia.Unico);
            ICriterio unCriterio = new CriterioFecha(new DateTime(2016, 11, 12), new DateTime(2016, 12, 12));
            Assert.IsTrue(unCriterio.cumpleCriterio(unEvento));
        }
    }
}