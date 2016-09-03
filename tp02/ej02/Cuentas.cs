using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ej02
{
    public class Cuentas
    {
        private Cuenta iCuentaCorriente;
        private Cuenta iCajaDeAhorro;
        private Cliente iCliente;

        public Cuentas(Cuenta pCajaDeAhorro, Cuenta pCuentaCorriente, Cliente pCliente)
        {
            this.iCuentaCorriente = pCuentaCorriente;
            this.iCajaDeAhorro = pCajaDeAhorro;
            this.iCliente = pCliente;
        }

        public Cuenta CuentaCorriente
        {
            get
            {
                return this.iCuentaCorriente;
            }
            set { }
        }

        public Cuenta CuentaCajaDeAhorro
        {
            get { return this.iCajaDeAhorro; }
            set { }
        }
    }
}