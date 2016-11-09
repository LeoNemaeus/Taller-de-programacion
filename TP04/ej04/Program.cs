using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ej04;

namespace ej04
{
    class Program
    {
        static void Main(string[] args)
        {
            FachadaBanco ctrl = new FachadaBanco();
            string opción;
            double x;

            // Ciclo menú principal.
            do
            {
                Console.Clear();
                Console.WriteLine("Gestión de cuentas - ingrese una opción:");
                Console.WriteLine("a - Acreditar saldo a caja de ahorro");
                Console.WriteLine("b - Acreditar saldo a cuenta corriente");
                Console.WriteLine("c - Debitar saldo a caja de ahorro");
                Console.WriteLine("d - Debitar saldo a cuenta corriente");
                Console.WriteLine("e - Transferir a caja de ahorro");
                Console.WriteLine("f - Transferir a cuenta corriente");
                Console.WriteLine("g - Consultar saldo caja de ahorro");
                Console.WriteLine("h - Consultar saldo cuenta corriente");
                Console.WriteLine("i - Consultar acuerdo caja de ahorro");
                Console.WriteLine("j - Consultar acuerdo cuenta corriente");
                Console.WriteLine("q - Salir");

                opción = Console.ReadLine();

                switch(opción)
                {
                    // Acreditar saldo a caja de ahorro
                    case "a":
                        Console.Clear();
                        Console.WriteLine("Gestión de cuentas - acreditar saldo a caja de ahorro:");

                        Console.Write("Ingrese el monto que desea acreditar: ");
                        x = Convert.ToDouble(Console.ReadLine());
                        try
                        {
                            ctrl.acreditarSaldoCajaAhorro(x);
                            Console.WriteLine("${0} acreditados", x);
                        }
                        catch (MovimientoException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        finally
                        {
                            Console.Write("Presione una tecla para continuar...");
                            Console.ReadKey();
                        }
                        break;
                    //Debitar saldo a caja de ahorro
                    case "b":
                        Console.Clear();
                        Console.WriteLine("Gestión de cuentas - acreditar saldo a cuenta corriente:");

                        Console.Write("Ingrese el monto que desea acreditar: ");
                        x = Convert.ToDouble(Console.ReadLine());
                        try
                        {
                            ctrl.acreditarSaldoCuentaCorriente(x);
                            Console.WriteLine("${0} acreditados", x);
                        }
                        catch(MovimientoException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        finally
                        {
                            Console.Write("Presione una tecla para continuar...");
                            Console.ReadKey();
                        }
                        break;
                    case "c":
                        Console.Clear();
                        Console.WriteLine("Gestión de cuentas - debitar saldo a caja de ahorro:");

                        Console.Write("Ingrese el monto que desea debitar: ");
                        x = Convert.ToDouble(Console.ReadLine());
                        try
                        {
                            ctrl.debitarSaldoCajaAhorro(x);
                            Console.WriteLine("${0} debitados", x);
                        }
                        catch (MovimientoException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        finally
                        {
                            Console.Write("Presione una tecla para continuar...");
                            Console.ReadKey();
                        }
                        break;
                    case "d":
                        Console.Clear();
                        Console.WriteLine("Gestión de cuentas - acreditar saldo a cuenta corriente:");

                        Console.Write("Ingrese el monto que desea acreditar: ");
                        x = Convert.ToDouble(Console.ReadLine());
                        try
                        {
                            ctrl.acreditarSaldoCuentaCorriente(x);
                            Console.WriteLine("${0} acreditados", x);
                        }
                        catch (MovimientoException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        finally
                        {
                            Console.Write("Presione una tecla para continuar...");
                            Console.ReadKey();
                        }
                        break;
                    case "e":
                        Console.Clear();
                        Console.WriteLine("Gestión de cuentas - debitar saldo a cuenta corriente:");

                        Console.Write("Ingrese el monto que desea debitar: ");
                        x = Convert.ToDouble(Console.ReadLine());
                        try {
                            ctrl.debitarSaldoCuentaCorriente(x);
                            Console.WriteLine("${0} debitados", x);
                        }
                        catch (MovimientoException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        finally
                        {
                            Console.Write("Presione una tecla para continuar...");
                            Console.ReadKey();
                        }
                        break;
                    // Consultar saldo caja de ahorro
                    case "f":
                        Console.Clear();
                        Console.WriteLine("Gestión de cuentas - transferir a caja de ahorro:");

                        Console.Write("Ingrese el monto que desea transferir: ");
                        x = Convert.ToDouble(Console.ReadLine());
                        try
                        {
                            ctrl.transferirACajaAhorro(x);
                            Console.WriteLine("${0} transferidos de la cuenta corriente a la caja de ahorro", x);
                        }
                        catch (MovimientoException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        finally
                        {
                            Console.Write("Presione una tecla para continuar...");
                            Console.ReadKey();
                        }
                        break;
                    case "g":
                        Console.Clear();
                        Console.WriteLine("Gestión de cuentas - transferir a cuenta corriente:");

                        Console.Write("Ingrese el monto que desea transferir: ");
                        x = Convert.ToDouble(Console.ReadLine());
                        try
                        {
                            ctrl.transferirACuentaCorriente(x);
                            Console.WriteLine("${0} transferidos de la caja de ahorro a la cuenta corriente", x);
                        }
                        catch (MovimientoException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        finally
                        {
                            Console.Write("Presione una tecla para continuar...");
                            Console.ReadKey();
                        }
                        break;
                    case "h":
                        Console.Clear();
                        Console.WriteLine("Gestión de cuentas - consultar saldo caja de ahorro:");

                        Console.WriteLine("Saldo caja de ahorro: ${0}", ctrl.SaldoCajaAhorro);

                        Console.Write("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case "i":
                        Console.Clear();
                        Console.WriteLine("Gestión de cuentas - consultar saldo cuenta corriente:");

                        Console.WriteLine("Saldo caja corriente: ${0}", ctrl.SaldoCuentaCorriente);

                        Console.Write("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case "j":
                        Console.Clear();
                        Console.WriteLine("Gestión de cuentas - consultar acuerdo caja de ahorro:");

                        Console.WriteLine("Acuerdo caja de ahorro: ${0}", ctrl.AcuerdoCajaAhorro);

                        Console.Write("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case "k":
                        Console.Clear();
                        Console.WriteLine("Gestión de cuentas - consultar acuerdo cuenta corriente:");

                        Console.WriteLine("Acuerdo cuenta corriente: ${0}", ctrl.AcuerdoCuentaCorriente);

                        Console.Write("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    default:
                        break;
            }
            // Salir
            } while (opción != "q");

        }
    }
}
