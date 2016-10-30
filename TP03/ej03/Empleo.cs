using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej03
{
    /// <summary>
    /// Mantiene el sueldo y la fecha de ingreso de un empleo.
    /// </summary>
    public class Empleo
    {
        readonly double iSueldo;
        readonly DateTime iFechaIngreso;

        public Empleo(double pSueldo, DateTime pFechaIngreso)
        {
            iSueldo = pSueldo;
            iFechaIngreso = pFechaIngreso;
        }

        public double Sueldo
        { get { return iSueldo; } }

        public DateTime FechaIngreso
        { get { return iFechaIngreso; } }
    }
}
