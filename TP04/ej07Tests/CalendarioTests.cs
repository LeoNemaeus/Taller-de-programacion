using Microsoft.VisualStudio.TestTools.UnitTesting;
using ej07;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej07.Tests
{
    [TestClass()]
    public class CalendarioTests
    {
        [TestMethod()]
        public void CalendarioTest()
        {
            Calendario mCalendario = new Calendario("Calendario 1");
            Assert.IsNotNull(mCalendario);
        }

        [TestMethod()]
        public void agregarEventoTest()
        {
            Calendario mCalendario = new Calendario("Calendario agregarEvento");
            Evento mEvento = new Evento("Evento 1", new DateTime(2016, 10, 25), TimeSpan.FromHours(1), Frecuencia.Anual);
            patron_filter.ICriterio mFiltro = new patron_filter.CriterioNombre(mEvento.Nombre);

            mCalendario.agregarEvento(mEvento);

            Evento mResultado = mCalendario.obtenerEventos(mFiltro).First();

            Assert.AreSame(mEvento, mResultado);
        }

        [TestMethod()]
        public void eliminarEventoTest()
        {
            Calendario mCalendario = new Calendario("Calendario eliminarEvento");
            Evento mEvento = new Evento("Evento 1", new DateTime(2016, 10, 25), TimeSpan.FromHours(1), Frecuencia.Anual);
            patron_filter.ICriterio mFiltro = new patron_filter.CriterioNombre(mEvento.Nombre);

            mCalendario.agregarEvento(mEvento);

            mCalendario.eliminarEvento(mEvento.Nombre);

            bool mResultado = mCalendario.obtenerEventos(mFiltro).Count() != 0;

            Assert.IsFalse(mResultado);
        }

        [TestMethod()]
        public void actualizarEventoTest()
        {
            Calendario mCalendario = new Calendario("Calendario actualizarEvento");
            Evento mEvento = new Evento("Evento 1", new DateTime(2016, 10, 25), TimeSpan.FromHours(1), Frecuencia.Anual);
            Evento mEventoActualizado = new Evento("Evento 1", new DateTime(2016, 09, 25), TimeSpan.FromHours(1), Frecuencia.Mensual);
            patron_filter.ICriterio mFiltro = new patron_filter.CriterioNombre(mEvento.Nombre);

            mCalendario.actualizarEvento(mEvento.Nombre, mEventoActualizado);

            Evento mResultado = mCalendario.obtenerEventos(mFiltro).First();

            Assert.AreSame(mEventoActualizado, mResultado);
        }

        [TestMethod()]
        public void obtenerEventosTest()
        {
            Calendario mCalendario = new Calendario("Calendario obtenerEvento");
            Evento mEvento = new Evento("Evento 1", new DateTime(2016, 10, 25), TimeSpan.FromHours(1), Frecuencia.Anual);
            patron_filter.ICriterio mFiltro = new patron_filter.CriterioNombre(mEvento.Nombre);

            mCalendario.agregarEvento(mEvento);

            Evento mResultado = mCalendario.obtenerEventos(mFiltro).First();

            Assert.AreSame(mEvento, mResultado);
        }
    }
}