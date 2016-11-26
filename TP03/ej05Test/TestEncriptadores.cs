using System;
using ej04;
using Ej05;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ej05Test
{
    [TestClass()]
    public class TestEncriptadores
        {
            [TestMethod]
            public void EncriptarDesencriptar()
            {
                EncriptadorInverso iEncriptador = new EncriptadorInverso();
                String palabraEncriptada = iEncriptador.Encriptar("Esto es una prueba de validacion para el encriptador Inverso");
                Assert.AreEqual(iEncriptador.Desencriptar(palabraEncriptada), "Esto es una prueba de validacion para el encriptador Inverso");
            }
        }
}
