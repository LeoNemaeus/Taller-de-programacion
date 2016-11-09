using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Clase Cliente: representa un cliente al que pertenecen las cuentas.
 */
namespace ej04
{
    /// <summary>
    /// Representa un Cliente.
    /// Propiedades:    - TipoDocumento
    ///                 - NroDocumento
    ///                 - Nombre
    /// </summary>
    public class Cliente
    {
        private String iNroDocumento;
        private String iNombre;
        private TipoDocumento iTipoDocumento;

        /// <summary>
        /// Inicializa una nueva instancia de un cliente.
        /// </summary>
        /// <param name="pTipoDocumento"></param>
        /// <param name="pNroDocumento"></param>
        /// <param name="pNombre"></param>
        public Cliente(TipoDocumento pTipoDocumento, string pNroDocumento, string pNombre)
        {
            this.iNroDocumento = pNroDocumento;
            this.iNombre = pNombre;
            this.iTipoDocumento = pTipoDocumento;
        }

        public TipoDocumento TipoDocumento
        {
            get
            {
                return this.iTipoDocumento;
            }

            set
            {
            }
        }

        public String NroDocumento
        {
            get
            {
                return this.iNroDocumento;
            }

            set
            {
            }
        }

        public String Nombre
        {
            get
            {
                return this.iNombre;
            }

            set
            {
            }
        }
    }
}