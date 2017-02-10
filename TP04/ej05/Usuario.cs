using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej05
{
    /// <sumary> Clase que mantiene el código, nombre completo y correo electrónico del usuario</sumary>>
    public class Usuario : IComparable<Usuario>
    {
        string iCodigo, iNombreCompleto, iCorreoElectronico;
        /// <summary>
        /// Código único del usuario.
        /// </summary>
        public string Codigo
        {
            get { return this.iCodigo; }
            set { this.iCodigo = value; }
        }
        /// <summary>
        /// Nombre completo de un usuario.
        /// </summary>
        public string NombreCompleto
        {
            get { return this.iNombreCompleto; }
            set { this.iNombreCompleto = value; }
        }
        /// <summary>
        /// Correo electrónico de un usuario.
        /// </summary>
        public string CorreoElectronico
        {
            get { return this.iCorreoElectronico; }
            set { this.iCorreoElectronico = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="unUsuario">  </param>
        /// <returns>  </returns>
        public int CompareTo(Usuario unUsuario)
        {
            return string.Compare(this.Codigo, unUsuario.Codigo);
        }
    }
}
