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
    public class CriterioOrTests
    {
        [TestMethod()]
        public void CriterioOrTest()
        {
            ICriterio unCriterio = new CriterioFecha(new DateTime(2016, 11, 12));
            ICriterio otroCriterio = new CriterioNombre("Asd");
            ICriterio criterioOr = new CriterioOr(unCriterio, otroCriterio);

            Assert.IsNotNull(criterioOr);
        }

        [TestMethod()]
        public void cumpleCriterioTest()
        {
            ICriterio unCriterio = new CriterioFecha(new DateTime(2016, 11, 12));
            ICriterio otroCriterio = new CriterioNombre("Asd");
            ICriterio criterioOr = new CriterioOr(unCriterio, otroCriterio);

            Evento unEvento = new Evento("Asd", new DateTime(2016, 11, 12), TimeSpan.FromHours(1), Frecuencia.Unico);

            Assert.IsTrue(criterioOr.cumpleCriterio(unEvento));
        }
    }
}