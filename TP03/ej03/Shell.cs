using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ej03
{
    /// <summary>
    /// Interfaz de usuario para la validación de prestamos. Utiliza la fachada Prestamos
    /// </summary>
    class Shell
    {
        public static void display()
        {
            Prestamos mPrestamos = new Prestamos();

            DateTime mNacimiento, mIngreso;

            Console.WriteLine("Validar prestamo");

            Console.WriteLine("Datos personales:");
            Console.Write("Nombre: ");
            string mNombre = Console.ReadLine();
            Console.Write("Apellido: ");
            string mApellido = Console.ReadLine();

            Console.Write("Fecha de nacimiento (yyyy-MM-dd): ");
            mNacimiento = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd", CultureInfo.InvariantCulture);

            Console.WriteLine("Empleo:");
            Console.Write("Sueldo: ");
            double mSueldo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Fecha de ingreso (yyyy-MM-dd): ");
            mIngreso = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd", CultureInfo.InvariantCulture);

            Console.WriteLine("Solicitud:");
            Console.Write("Monto: ");
            double mMonto = Convert.ToDouble(Console.ReadLine());
            Console.Write("Cuotas: ");
            int mCuotas = Convert.ToInt16(Console.ReadLine());
            Console.Write("Tipo de cliente (No cliente): ");
            string mTipoCliente = Console.ReadLine();

            
            if (mPrestamos.evaluarSolicitud(mNombre, mApellido, mNacimiento, mSueldo, mIngreso, mMonto, mCuotas, mTipoCliente))
            {
                Console.WriteLine("Solicitud valida");
            } else
            {
                Console.WriteLine("Solicitud invalida");
            }
        }
    }
}
