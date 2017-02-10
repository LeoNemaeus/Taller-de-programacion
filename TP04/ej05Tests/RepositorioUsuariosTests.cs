using Microsoft.VisualStudio.TestTools.UnitTesting;
using ej05;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej05.Tests
{
    [TestClass()]
    public class RepositorioUsuariosTests
    {

        [TestMethod()]
        public void AgregarTest()
        {
            IRepositorioUsuarios unRepositorio = new RepositorioUsuarios();
            Usuario unUsuario = new Usuario()
            { Codigo = "1", NombreCompleto = "Juan", CorreoElectronico = "Juan1@gmail.com" };

            unRepositorio.Agregar(unUsuario);
            Assert.IsTrue(unRepositorio.ObtenerTodos().Contains(unUsuario));
        }

        [TestMethod()]
        public void ActualizarTest()
        {
            IRepositorioUsuarios unRepositorio = new RepositorioUsuarios();
            Usuario unUsuario = new Usuario()
            { Codigo = "1", NombreCompleto = "Juan", CorreoElectronico = "Juan1@gmail.com" };
            Usuario unUsuarioActualizado = new Usuario()
            { Codigo = "1", NombreCompleto = "Pedro", CorreoElectronico = "pedro@gmail.com" };

            unRepositorio.Agregar(unUsuario);

            unRepositorio.Actualizar(unUsuarioActualizado);

            Assert.IsTrue(unRepositorio.ObtenerTodos().Contains(unUsuarioActualizado));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            IRepositorioUsuarios unRepositorio = new RepositorioUsuarios();
            Usuario unUsuario = new Usuario()
            { Codigo = "1", NombreCompleto = "Juan", CorreoElectronico = "Juan1@gmail.com" };

            unRepositorio.Agregar(unUsuario);

            unRepositorio.Eliminar(unUsuario.Codigo);
            Assert.IsFalse(unRepositorio.ObtenerTodos().Contains(unUsuario));
        }

        [TestMethod()]
        public void ObtenerTodosTest()
        {
            Usuario nuevoUsuario = new Usuario()
            { Codigo = "1", NombreCompleto = "Juan", CorreoElectronico = "Juan1@gmail.com" };
            Usuario nuevoUsuario2 = new Usuario()
            { Codigo = "2", NombreCompleto = "Juega German", CorreoElectronico = "Juan1@gmail.com" };
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

        [TestMethod()]
        public void ObtenerPorCodigoTest()
        {

            IRepositorioUsuarios unRepositorio = new RepositorioUsuarios();
            Usuario unUsuario = new Usuario()
            { Codigo = "1", NombreCompleto = "Juan", CorreoElectronico = "Juan1@gmail.com" };

            unRepositorio.Agregar(unUsuario);
            Assert.AreEqual(unRepositorio.ObtenerPorCodigo(unUsuario.Codigo).Codigo, unUsuario.Codigo);
        }

        [TestMethod()]
        public void ObtenerOrdenadosPorTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void CompareTest()
        {
            Assert.Fail();
        }
    }
}