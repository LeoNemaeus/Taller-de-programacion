using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej05
{
    public class RepositorioUsuarios : IRepositorioUsuarios
    {
        private IDictionary<string, Usuario> iRepositorio;
        /// <summary>
        /// Constructor del repositorio de usuarios.
        /// </summary>
        public RepositorioUsuarios()
        {
            iRepositorio = new SortedDictionary<string, Usuario>();
        }

        /// <summary>
        /// Propiedad del repositorio
        /// </summary>
        public IDictionary<string, Usuario> Repositorio
        {
            get { return this.iRepositorio; }
        }

        /// <summary>
        /// Método utilizado para agregar un usuario al repositorio.
        /// Si el usuario ya se encuentra registrado se lanza una excepción. 
        /// </summary>
        /// <param name="pUsuario">Usuario que va a agregar. </param>
        public void Agregar(Usuario pUsuario)
        {
            if (this.iRepositorio.ContainsKey(pUsuario.Codigo))
            {
                throw new ExcepcionUsuarioExistente("El usuario que desea agregar ya se encuentra registrado. ");
            }
            else
            {
                this.iRepositorio.Add(pUsuario.Codigo, pUsuario);
            }
        }

        /// <summary>
        /// Método utilizado para actualizar un usuario existente. Si la clave "código" 
        /// no se encuentra se lanza una excepción.
        /// </summary>
        /// <param name="pUsuario">Usuario que se desea actualizar</param>
        public void Actualizar(Usuario pUsuario)
        {
            if (!(this.iRepositorio.ContainsKey(pUsuario.Codigo)))
            {
                throw new ExcepcionClaveInvalida("La clave proporcionada es inválida o no existe. ");
            }
            else
            {
                this.iRepositorio[pUsuario.Codigo] = pUsuario;
            }
        }

        /// <summary>
        /// Método utilizado para eliminar un usuario del repositorio.
        /// Si el usuario no se encuentra se lanza una excepción.
        /// </summary>
        /// <param name="pCodigo">parámetro utilizado para localizar el usuario a eliminar.</param>
        public void Eliminar(string pCodigo)
        {
            if (this.iRepositorio.ContainsKey(pCodigo))
            {
                this.iRepositorio.Remove(pCodigo);
            }
            else
            {
                throw new ExcepcionClaveInvalida("La clave proporcionada es inválida o no existe. ");
            }
        }
        /// <summary>
        /// Método para obtener los usuarios ingresados.
        /// </summary>
        /// <returns>Una lista con todos los usuarios. </returns>
        public IList<Usuario> ObtenerTodos()
        {
            return (List<Usuario>)iRepositorio.Values.ToList();
        }

        /// <summary>
        /// Método por el cuál se obtiene un usuario.
        /// </summary>
        /// <param name="pCodigo"> parámetro mediante el cuál busca el usuario. </param>
        /// <returns>Devuelve el usuario. </returns>
        public Usuario ObtenerPorCodigo(string pCodigo)
        {
            if (this.iRepositorio.ContainsKey(pCodigo))
            {
                return this.iRepositorio[pCodigo];
            }
            else
            {
                throw new ExcepcionClaveInvalida("La clave proporcionada es inválida o no existe. ");
            }
        }
        /// <summary>
        /// Obtiene una lista de usuarios.
        /// </summary>
        /// <param name="pComparador">paámetro mediante el cuál va a ordenar la lista</param>
        /// <returns>Una nueva lista con los usuarios ordenados.</returns>
        public IList<Usuario> ObtenerOrdenadosPor(IComparer<Usuario> pComparador)
        {
            var ordenados = new List<Usuario>(this.iRepositorio.Values);
            ordenados.Sort(pComparador);
            return ordenados.ToList();
        }

        public int Compare(Usuario x, Usuario y)
        {
            return x.CompareTo(y);
        }
    }
}
