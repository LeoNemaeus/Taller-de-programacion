using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej03
{
    class Empleo
    {
        double iSueldo;
        DateTime iFechaIngreso;

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
