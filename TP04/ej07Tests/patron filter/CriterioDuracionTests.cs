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
    public class CriterioDuracionTests
    {
        [TestMethod()]
        public void cumpleCriterioTest()
        {
            Evento unEvento = new Evento("", new DateTime(2016, 11, 12), TimeSpan.FromHours(1), Frecuencia.Unico);
            CriterioDuracion criterioCorrecto = new CriterioDuracion(TimeSpan.FromHours(1));
            CriterioDuracion criterioIncorrecto = new CriterioDuracion(TimeSpan.FromHours(2));

            Assert.IsTrue(criterioCorrecto.cumpleCriterio(unEvento));
            Assert.IsFalse(criterioIncorrecto.cumpleCriterio(unEvento));
        }
    }
}