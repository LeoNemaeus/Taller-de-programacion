using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Clase Cuenta: representa una cuenta bancara con un saldo, acuerdo de
 * descubierto.
 * Mensajes: -Saldo: obtiene el saldo actual de la cuenta
 *           -Acuerdo: obtiene el acuerdo de descubierto
 *           -AcreditarSaldo: suma a la cuenta el saldo indicado
 *           -DebitarSaldo: debita del saldo el monto indicado, siempre que haya
 *           saldo suficiente o que el acuerdo de descubierto cubra el monto.
 */

namespace ejercicio2
{
    public class Cuenta
    {
        private double iSaldo;
        private double iAcuerdo;

        //Constructor con acuerdo
        public Cuenta(double pAcuerdo)
        {
            this.iAcuerdo = pAcuerdo;
        }

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

            set
            {
            }
        }

        public void AcreditarSaldo(double pSaldo)
        {
            this.iSaldo += pSaldo;
        }

        public bool DebitarSaldo(double pSaldo)
        {
             //Verifica que el saldo en la cuenta sea mayor o igual que el que se va a
             //extraer o bien que el saldo no alcance, pero el acuerdo cubra el debito
            if ((this.iSaldo >= pSaldo) || (this.iSaldo < pSaldo) & (this.iAcuerdo >= pSaldo))
            {
                this.iSaldo -= pSaldo;
                return true;
            } else
            {
                return false;
            }
        }
    }
}