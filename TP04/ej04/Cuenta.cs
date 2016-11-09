using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ej04;
/*
 * Clase Cuenta: representa una cuenta bancara con un saldo, acuerdo de
 * descubierto.
 * Mensajes: -Saldo: obtiene el saldo actual de la cuenta
 *           -Acuerdo: obtiene el acuerdo de descubierto
 *           -AcreditarSaldo: suma a la cuenta el saldo indicado
 *           -DebitarSaldo: debita del saldo el monto indicado, siempre que haya
 *           saldo suficiente o que el acuerdo de descubierto cubra el monto.
 */

namespace ej04
{
    public class Cuenta
    {
        private double iSaldo;
        private double iAcuerdo;
            
        //Constructor con acuerdo
        public Cuenta(double pAcuerdo) : this (pAcuerdo, 0) { }

        //Constructor con saldo inicial y acuerdo
        public Cuenta(double pAcuerdo, double pSaldoInicial)
        {
            this.iAcuerdo = pAcuerdo;
            this.iSaldo = pSaldoInicial;
        }

        //Getter para la propiedad Saldo
        public double Saldo
        {
            get
            {
                return this.iSaldo;
            }

            set
            {
            }
        }

        //Getter para la propiedad Acuerdo
        public double Acuerdo
        {
            get
            {
                return this.iAcuerdo;
            }
        }

        /// <summary>
        /// Acredita saldo a una cuenta. No puede ser nulo o negativo, sino lanza una MovimientoException
        /// </summary>
        /// <param name="pSaldo"></param>
        public void AcreditarSaldo(double pSaldo)
        {
            if (pSaldo >= 0)
            {
                iSaldo += pSaldo;
            } else
            {
                throw new MovimientoException("No se puede acreditar un saldo nulo o  negativo: " + pSaldo);
            }
        }

        /// <summary>
        /// Debita un monto a una cuenta. No puede ser mayor que el saldo de la cuenta y el acuerdo, sino lanza una MovimientoException
        /// </summary>
        /// <param name="pSaldo"></param>
        public void DebitarSaldo(double pSaldo)
        {
             //Verifica que el saldo en la cuenta sea mayor o igual que el que se va a
             //extraer o bien que el saldo no alcance, pero el acuerdo cubra el debito
            if ((this.iAcuerdo + this.iSaldo) >= pSaldo)
            {
                iSaldo -= pSaldo;
            } else
            {
                throw new MovimientoException("El monto a debitar es mayor que el saldo y el acuerdo de la caja");
            }
        }
    }
}