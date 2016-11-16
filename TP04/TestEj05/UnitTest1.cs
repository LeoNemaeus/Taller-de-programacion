using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ej05;

namespace TestEj05
{
    [TestClass]
    public class Ejercicio05
    {
        /*[TestMethod]
        public void AgregarUsuario()
        {
            Usuario nuevoUsuario = new Usuario() 
            { Codigo = "1", NombreCompleto = "Juan", CorreoElectronico = "Juan1@gmail.com" };

            RepositorioUsuarios nuevoRepositorio = new RepositorioUsuarios();
            nuevoRepositorio.Agregar(nuevoUsuario);
            
            Assert.AreEqual(nuevoRepositorio.IRepositorioUsuarios.ContainsKey("1"), true);
        }*/

        [TestMethod]
        public void ObtenerTodos()
        {
            Usuario nuevoUsuario = new Usuario() 
                { Codigo = "1", NombreCompleto = "Juan", CorreoElectronico = "Juan1@gmail.com" };
            Usuario nuevoUsuario2 = new Usuario() 
                { Codigo = "2", NombreCompleto = "German", CorreoElectronico = "Juan1@gmail.com" };
            Usuario nuevoUsuario3 = new Usuario() 
                { Codigo = "3", NombreCompleto = "Jennifer", CorreoElectronico = "Juan1@gmail.com" };

            RepositorioUsuarios nuevoRepo = new RepositorioUsuarios();

            nuevoRepo.Agregar(nuevoUsuario);
            nuevoRepo.Agregar(nuevoUsuario2);
            nuevoRepo.Agregar(nuevoUsuario3);


            Assert.AreEqual((nuevoRepo.ObtenerTodos()).Contains(nuevoUsuario) 
                && (nuevoRepo.ObtenerTodos()).Contains(nuevoUsuario2) 
                && (nuevoRepo.ObtenerTodos()).Contains(nuevoUsuario3), true);
        }

    }
}
