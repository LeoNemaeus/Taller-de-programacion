using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ej02
{
    /// <summary>
    /// Clase Cuentas: mantiene una cuenta corriente, una cuenta de ahorro y un cliente.
    /// propiedades:    - CuentaCorriente devuelve una cuenta conteniendo la cuenta corriente.
    ///                 - CuentaCajaDeAhorro devuelve una cuenta conteniendo la caja de ahorro.
    /// </summary>
    public class Cuentas
    {
        private Cuenta iCuentaCorriente;
        private Cuenta iCajaDeAhorro;
        private Cliente iCliente;

        /// <summary>
        /// Constructor: inicializa una instancia de Cuentas.
        /// </summary>
        /// <param name="pCajaDeAhorro">Una caja de ahorro</param>
        /// <param name="pCuentaCorriente">Una cuenta corriente</param>
        /// <param name="pCliente">Un cliente</param>
        public Cuentas(Cuenta pCajaDeAhorro, Cuenta pCuentaCorriente, Cliente pCliente)
        {
            this.iCuentaCorriente = pCuentaCorriente;
            this.iCajaDeAhorro = pCajaDeAhorro;
            this.iCliente = pCliente;
        }

        /// <summary>
        /// Devuelve la cuenta corriente almacenada
        /// </summary>
        public Cuenta CuentaCorriente
        {
            get
            {
                return this.iCuentaCorriente;
            }
            set { }
        }

        /// <summary>
        /// Devuelve la caja de ahorro almacenada
        /// </summary>
        public Cuenta CuentaCajaDeAhorro
        {
            get { return this.iCajaDeAhorro; }
            set { }
        }
    }
}