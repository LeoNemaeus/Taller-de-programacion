using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej05
{
    class Fechas

    {
        // Atributos
        private const int AÑO_BASE = 1900, AÑO_MAXIMO = 2199;
        private static readonly int [] CANTIDAD_DIAS_MES = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private static readonly int [] CLAVE_MES = { 0, 3, 3, 6, 1, 4, 6, 2, 5, 0, 3, 5 };
        private static readonly int [] CLAVE_SIGLO = { 0, 6, 4, 2, 0, 6 };
        private static readonly String [] DIA_SEMANA = { "Domingo", "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado" };

        private readonly long iCantidadDias;
        private readonly int iDia, iMes, iAño;

        //Constructores 

        private Fechas(int pDia, int pMes, int pAño)

        {
            this.iDia = pDia;
            this.iMes = pMes;
            this.iAño = pAño;
        }

        // Propiedades

        private int Dia
        {
            get { return this.iDia; }

        }
        private int Mes
        {
            get { return this.iMes; }

        }
        private int Año
        {
            get { return this.iAño; }

        }

        // En el método CalcularCantidadDiasMes se ingresan como parámetros el dia mes y el año.
        // Controla que el año no sea bisiesto, controlando el mes de febrero.
        private static int CalcularCantidadDiasMes(int pMes, int pAño)
        {
            int mCantidadDias = CANTIDAD_DIAS_MES[pMes - 1];

            // Si el mes es febrero y el año no es bisiesto entonces debo quitarle
            // una unidad al número recuperado.
            if (pMes == 2 && !Fechas.EsBisiesto(pAño))
            {
                mCantidadDias -= 1;
            }

            return mCantidadDias;
        }

        // En el método CalcularCantidadDiasAño, controla si el año es bisiesto le suma 1 día a la variable mCantidadDias.
        private static int CalcularCantidadDiasAño(int pAño)
        {
            int mCantidadDias = 365;

            if (Fechas.EsBisiesto(pAño))
            {
                mCantidadDias++;
            }

            return mCantidadDias;
        }
        // Realiza el cálculo del año en caso de ser bisiesto.
        private static bool EsBisiesto(int pAño)
        {
            return pAño % 4 == 0 || (pAño % 100 != 0 && pAño % 400 == 0);
        }



    }
}


}
