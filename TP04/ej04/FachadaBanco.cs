using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ej04
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
        /// Agrega al saldo de la cuenta corriente el valor de pSaldo. Lanza MovimientoException.
        /// </summary>
        /// <param name="pSaldo">Monto a sumar al saldo de la cuenta corriente.</param>
        public void acreditarSaldoCuentaCorriente(double pSaldo)
        {
            iCuentaCorriente.AcreditarSaldo(pSaldo);
        }

        /// <summary>
        /// Suma a la caja de ahorro el valor de pSaldo. Lanza MovimientoException. Lanza MovimientoException.
        /// </summary>
        /// 
        /// <param name="pSaldo">Monto a sumar al saldo de la caja de ahorro</param>
        public void acreditarSaldoCajaAhorro(double pSaldo)
        {
            iCajaAhorro.AcreditarSaldo(pSaldo);
        }

        /// <summary>
        /// Debita de la cuenta corriente el valor de pSaldo mientras sea menor que la suma de los fondos de la cuenta y el acuerdo de descubierto. Lanza MovimientoException.
        /// </summary>
        /// <param name="pSaldo">Monto a debitar</param>
        public void debitarSaldoCuentaCorriente(double pSaldo)
        {
            iCuentaCorriente.DebitarSaldo(pSaldo);
        }

        /// <summary>
        /// Debita de la cuenta corriente el valor de pSaldo mientras sea menor que la suma de los fondos de la cuenta y el acuerdo de descubierto. Lanza MovimientoException.
        /// </summary>
        /// <param name="pSaldo">Monto a debitar</param>
        public void debitarSaldoCajaAhorro(double pSaldo)
        {
            iCajaAhorro.DebitarSaldo(pSaldo);
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

        /// <summary>
        /// Permite transferir de la caja de ahorro a la cuenta corriente.
        /// </summary>
        /// <param name="pMonto">
        /// Monto a transferir entre cuentas. El monto no puede superar el saldo
        /// de la cuenta corriente.
        /// </param>
        /// <returns>
        /// Verdadero si la transferencia fue exitosa, falso sino
        /// </returns>
        public void transferirACuentaCorriente(double pMonto)
        {
            debitarSaldoCajaAhorro(pMonto);
            acreditarSaldoCuentaCorriente(pMonto);
        }

        /// <summary>
        /// Permite transferir de la cuenta corriente a la caja de ahorro
        /// </summary>
        /// <param name="pMonto">
        /// Monto a transferir entre cuentas. El monto no puede superar el saldo
        /// de la caja de ahorro.
        /// </param>
        /// <returns>
        /// Verdadero si la transferencia fue exitosa, falso sino
        /// </returns>
        public void transferirACajaAhorro(double pMonto)
        {
            debitarSaldoCuentaCorriente(pMonto);
            acreditarSaldoCajaAhorro(pMonto);
        }
    }
}