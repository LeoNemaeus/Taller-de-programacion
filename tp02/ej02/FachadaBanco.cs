using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejercicio2
{
    public class FachadaBanco
    {
        private iCliente = new Cliente(DNI, 39034583, "Sandro Pastorini");
        private iCajaAhorro = new Cuenta(500, 300);
        private iCuentaCorriente = new Cuenta(1500);
        private iCuentas = new Cuentas(iCajaAhorro, iCuentaCorriente, iCliente);

        public bool acreditarSaldoCajaDeAhorro(double pSaldo)
        {
        	
        }
    }
}