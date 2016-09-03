using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ej02;

namespace ej02
{
    class Program
    {
        static void Main(string[] args)
        {
            FachadaBanco ctrl = new FachadaBanco();
            string opción;
            double x;

            do
            {
                Console.Clear();
                Console.WriteLine("Gestión de cuentas - ingrese una opción:");
                Console.WriteLine("a - Acreditar saldo a caja de ahorro");
                Console.WriteLine("b - Debitar saldo a caja de ahorro");
                Console.WriteLine("c - Acreditar saldo a cuenta corriente");
                Console.WriteLine("d - Debitar saldo a cuenta corriente");
                Console.WriteLine("e - Consultar saldo caja de ahorro");
                Console.WriteLine("f - Consultar saldo cuenta corriente");
                Console.WriteLine("g - Consultar acuerdo caja de ahorro");
                Console.WriteLine("h - Consultar acuerdo cuenta corriente");
                Console.WriteLine("q - Salir");

                opción = Console.ReadLine();

                switch(opción)
                {
                    case "a":
                        Console.Clear();
                        Console.WriteLine("Gestión de cuentas - acreditar saldo a caja de ahorro:");

                        Console.Write("Ingrese el monto que desea acreditar: ");
                        x = Convert.ToDouble(Console.ReadLine());
                        ctrl.acreditarSaldoCajaAhorro(x);
                        Console.WriteLine("${0} acreditados", x);

                        Console.Write("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case "b":
                        Console.Clear();
                        Console.WriteLine("Gestión de cuentas - debitar saldo a caja de ahorro:");

                        Console.Write("Ingrese el monto que desea debitar: ");
                        x = Convert.ToDouble(Console.ReadLine());
                        if (ctrl.debitarSaldoCajaAhorro(x))
                        {
                            Console.WriteLine("${0} debitados", x);
                        } else {
                            Console.WriteLine("Error: el monto supera el saldo y el acuerdo de descubierto");
                        }

                        Console.Write("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case "c":
                        Console.Clear();
                        Console.WriteLine("Gestión de cuentas - acreditar saldo a cuenta corriente:");

                        Console.Write("Ingrese el monto que desea acreditar: ");
                        x = Convert.ToDouble(Console.ReadLine());
                        ctrl.acreditarSaldoCuentaCorriente(x);
                        Console.WriteLine("${0} acreditados", x);

                        Console.Write("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case "d":
                        Console.Clear();
                        Console.WriteLine("Gestión de cuentas - debitar saldo a cuenta corriente:");

                        Console.Write("Ingrese el monto que desea debitar: ");
                        x = Convert.ToDouble(Console.ReadLine());
                        if (ctrl.debitarSaldoCuentaCorriente(x))
                        {
                            Console.WriteLine("${0} debitados", x);
                        } else {
                            Console.WriteLine("Error: el monto supera el saldo y el acuerdo de descubierto");
                        }
                        Console.Write("Presione una tecla para continuar...");

                        Console.ReadKey();
                        break;
                    case "e":
                        Console.Clear();
                        Console.WriteLine("Gestión de cuentas - consultar saldo caja de ahorro:");

                        Console.WriteLine("Saldo caja de ahorro: ${0}", ctrl.SaldoCajaAhorro);

                        Console.Write("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case "f":
                        Console.Clear();
                        Console.WriteLine("Gestión de cuentas - consultar saldo cuenta corriente:");

                        Console.WriteLine("Saldo caja corriente: ${0}", ctrl.SaldoCuentaCorriente);

                        Console.Write("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case "g":
                        Console.Clear();
                        Console.WriteLine("Gestión de cuentas - consultar acuerdo caja de ahorro:");

                        Console.WriteLine("Acuerdo caja de ahorro: ${0}", ctrl.AcuerdoCajaAhorro);

                        Console.Write("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case "h":
                        Console.Clear();
                        Console.WriteLine("Gestión de cuentas - consultar acuerdo cuenta corriente:");

                        Console.WriteLine("Acuerdo cuenta corriente: ${0}", ctrl.AcuerdoCuentaCorriente);

                        Console.Write("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    default:
                        break;
            }
            } while (opción != "q");

        }
    }
}
