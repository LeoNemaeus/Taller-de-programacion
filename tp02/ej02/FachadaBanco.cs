using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ej02
{
    /// <summary>
    /// Crea un cliente y las cuentas asociadas. Permite sumar o restar al saldo.
    /// </summary>
    public class FachadaBanco
    {
        protected Cliente iCliente;
        protected Cuenta iCajaAhorro;
        protected Cuenta iCuentaCorriente;
        private Cuentas iCuentas;

        /// <summary>
        /// Crea las cuentas Caja de Ahorro y Cuenta Corriente para un cliente.
        /// </summary>
        public FachadaBanco()
        {
            iCliente = new Cliente(TipoDocumento.DNI, "39034583", "Sandro Pastorini");
            iCajaAhorro = new Cuenta(500);
            iCuentaCorriente = new Cuenta(1500, 1000);
            iCuentas = new Cuentas(iCajaAhorro, iCuentaCorriente, iCliente);
        }

        /// <summary>
        /// Agrega al saldo de la cuenta corriente el valor de pSaldo.
        /// </summary>
        /// <param name="pSaldo">Monto a sumar al saldo de la cuenta corriente.</param>
        public void acreditarSaldoCuentaCorriente(double pSaldo)
        {
            iCuentaCorriente.AcreditarSaldo(pSaldo);
        }

        /// <summary>
        /// Suma a la caja de ahorro el valor de pSaldo
        /// </summary>
        /// 
        /// <param name="pSaldo">Monto a sumar al saldo de la caja de ahorro</param>
        public void acreditarSaldoCajaAhorro(double pSaldo)
        {
            iCajaAhorro.AcreditarSaldo(pSaldo);
        }

        /// <summary>
        /// Debita de la cuenta corriente el valor de pSaldo mientras sea menor que la suma de los fondos de la cuenta y el acuerdo de descubierto.
        /// </summary>
        /// <param name="pSaldo">Monto a debitar</param>
        /// <returns>Verdadero si el monto es menor que los fondos y el acuerdo, falso sino.</returns>
        public bool debitarSaldoCuentaCorriente(double pSaldo)
        {
            return iCuentaCorriente.DebitarSaldo(pSaldo);
        }

        /// <summary>
        /// Debita de la cuenta corriente el valor de pSaldo mientras sea menor que la suma de los fondos de la cuenta y el acuerdo de descubierto.
        /// </summary>
        /// <param name="pSaldo">Monto a debitar</param>
        /// <returns>Verdadero si el monto es menor que los fondos y el acuerdo, falso sino.</returns>
        public bool debitarSaldoCajaAhorro(double pSaldo)
        {
            return iCuentaCorriente.DebitarSaldo(pSaldo);
        }

        /// <summary>
        /// Permite consultar el saldo de la caja de ahorro
        /// </summary>
        /// <returns>Saldo caja de ahorro</returns>
        public double SaldoCajaAhorro
        {
            get { return iCajaAhorro.Saldo; }
        }

        /// <summary>
        /// Permite consultar el acuerdo de descubierto de la caja de ahorro
        /// </summary>
        /// <returns>Acuerdo descubierto caja de ahorro</returns>
        public double AcuerdoCajaAhorro
        {
            get { return iCajaAhorro.Acuerdo; }
        }

        /// <summary>
        /// Permite consultar el saldo de la cuenta corriente
        /// </summary>
        /// <returns>Saldo cuenta corriente</returns>
        public double SaldoCuentaCorriente
        {
            get { return iCuentaCorriente.Saldo; }
        }

        /// <summary>
        /// Permite consultar el acuerdo de descubierto de la cuenta corriente
        /// </summary>
        /// <returns>Acuerdo de descubierto cuenta corriente</returns>
        public double AcuerdoCuentaCorriente
        {
            get { return iCuentaCorriente.Acuerdo; }
        }
    }
}