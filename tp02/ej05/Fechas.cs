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
        private const int AÑO_BASE = 1900, AÑO_MAXIMO = 2499;
        private static readonly int[] CANTIDAD_DIAS_MES = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private static readonly int[] CLAVE_MES = { 0, 3, 3, 6, 1, 4, 6, 2, 5, 0, 3, 5 };
        private static readonly int[] CLAVE_SIGLO = { 0, 6, 4, 2, 0, 6 };
        private static readonly String[] DIA_SEMANA = { "Domingo", "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado" };

        //Cantidad de días transcurridos desde la fecha base
        private readonly long iCantidadDias;
        //Componente día de la fecha, componente mes de la fecha y componente año de la fecha.
        private readonly int iDia, iMes, iAño;
//----------------------------------------------------------------------------------------------------------------------------------
        // Propiedades

        public int Dia
        {
            get { return this.iDia; }

        }
        public int Mes
        {
            get { return this.iMes; }

        }
        public int Año
        {
            get { return this.iAño; }

        }
//------------------------------------------------------------------------------------------------------------------------------------

        // Constructor de la clase
        public Fechas (int pDia, int pMes, int pAño)
        {
            if ((pAño < AÑO_BASE || pAño > AÑO_MAXIMO) && (pMes < 1 || pMes > 12) && (pDia < 1 || pDia > Fechas.CalcularCantidadDiasMes(pMes, pAño)))
            {
                this.iDia = pDia;
                this.iMes = pMes;
                this.iAño = pAño;

                // Por lo menos, desde la fecha base han pasado la cantidad de días
                // del componente día de la fecha.
                long mCantidadDias = pDia;

                // Se calculan la cantidad de días de los meses transcurridos desde enero hasta
                // el mes anterior al componente mes provisto, ya que dicho mes no está
                // completo y sus días ya fueron considerados.
                for (int bMes = 1; bMes < pMes; bMes++)
                {
                    mCantidadDias += Fechas.CalcularCantidadDiasMes(bMes, pAño);
                }

                // Se calculan la cantidad de días transcurridos desde el año base
                // hasta el año anterior al del componente año, ya que se han sumado
                // los días y meses de dicho año.
                for (int bAño = AÑO_BASE; bAño < pAño; bAño++)
                {
                    mCantidadDias += Fechas.CalcularCantidadDiasAño(bAño);
                }

                this.iCantidadDias = mCantidadDias;
            }
            else
            {
                this.iDia = 1;
                this.iAño = AÑO_BASE;
                this.iCantidadDias = 1;
                this.iMes = 1;
            }
        }
//---------------------------------------------------------------------------------------------------------------------------------
        //Constructor.. ¿?
        private Fechas(long pCantidadDias)
        {

            if (pCantidadDias < 1 || pCantidadDias > 219146)
            {

                this.iCantidadDias = pCantidadDias;

                int mAñoActual = AÑO_BASE;

                int mCantidadDiasAñoActual = Fechas.CalcularCantidadDiasAño(mAñoActual);

                // Se van sumando años al año base siempre y cuando la cantidad de días
                // sea suficiente para el año que se quiera sumar.
                while (pCantidadDias > mCantidadDiasAñoActual)
                {
                    mAñoActual++;
                    pCantidadDias -= mCantidadDiasAñoActual;
                    mCantidadDiasAñoActual = Fechas.CalcularCantidadDiasAño(mAñoActual);
                }

                this.iAño = mAñoActual;

                int mMesActual = 1;

                int mCantidadDiasMesActual = Fechas.CalcularCantidadDiasMes(mMesActual, this.iAño);

                // Se van sumando meses siempre y cuando haya suficientes días para
                // el mes que se esté tratando.
                while (pCantidadDias > mCantidadDiasMesActual)
                {
                    mMesActual++;
                    pCantidadDias -= mCantidadDiasMesActual;
                    mCantidadDiasMesActual = Fechas.CalcularCantidadDiasMes(mMesActual, this.iAño);
                }

                this.iMes = mMesActual;

                // El componente día es lo que quedó de quitar los días transcurridos
                // en los años y en los meses.
                this.iDia = (int)pCantidadDias;
            }
            else
            {
                this.iDia = 1;
                this.iMes = 1;
                this.iAño = AÑO_BASE;
                this.iCantidadDias = 1;
            }
        }
//_____________________________________________________________________________________________________________________________
        // En el método CalcularCantidadDiasMes se ingresan como parámetros el mes y el año.
        // Controla que el año no sea bisiesto, controlando el mes de febrero.
        private static int CalcularCantidadDiasMes(int pMes, int pAño)
        {
            int mCantidadDias = CANTIDAD_DIAS_MES[pMes - 1];

            // Si el mes es febrero y el año no es bisiesto entonces debo quitarle
            // una unidad al número recuperado.
            if (pMes == 2 && Fechas.EsBisiesto(pAño))
            {
                mCantidadDias += 1;
            }

            return mCantidadDias;
        }
//______________________________________________________________________________________________________________________________________
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

//__________________________________________________________________________________________________________________________
        // Realiza el cálculo del año en caso de ser bisiesto.
        private static bool EsBisiesto(int pAño)
        {
            return (pAño % 4 == 0 || (pAño % 100 != 0 && pAño % 400 == 0));
        }
//___________________________________________________________________________________________________________________________

        // Método agregar dias
        public Fechas AgregarDias(int pCantidadDias)
        {
            return new Fechas(this.iCantidadDias + pCantidadDias);
        }
//____________________________________________________________________________________________________________________________
       // Método agregar meses
        public Fechas AgregarMeses(int pCantidadMeses)
        {

            int mCantidadDias = 0;

            int mMesActual = this.iMes;
            int mAñoActual = this.iAño;

            for (int bIndice = 1; bIndice <= pCantidadMeses; bIndice++)
            {

                // En la próxima iteración luego de diciembre, vuelvo a enero e
                // incremento el año.
                if (mMesActual == 12)
                {
                    mMesActual = 1;
                    mAñoActual++;
                }
                else
                {
                    mMesActual++;
                }

                mCantidadDias += Fechas.CalcularCantidadDiasMes(mMesActual, mAñoActual);
            }

            return new Fechas(this.iCantidadDias + mCantidadDias);
        }
//_____________________________________________________________________________________________________________________________________
        //Método agregar años
        public Fechas AgregarAños(int pAños)
        {
            int mCantidadDias = 0;

            for (int bIndice = 1; bIndice <= pAños; bIndice++)
            {

                mCantidadDias += Fechas.CalcularCantidadDiasAño(this.iAño + bIndice);
            }

            return new Fechas(this.iCantidadDias + mCantidadDias);
        }

        public bool EsBisiesto()
        {
            return Fechas.EsBisiesto(this.iAño);
        }
        // Retorna el dia de la semana correspondiente
        public String DiaDeLaSemana
        {
            get
            {
                int mClaveSiglo = CLAVE_SIGLO[Convert.ToInt32(Convert.ToString(this.iAño).Substring(0, 2)) - 19];

                int mAño = Convert.ToInt32(Convert.ToString(this.iAño).Substring(2, 2));
                // Para obtener el índice del día de la semana, se utiliza la fórmula
                // N = (D + M + A + [A/4] + S) mod 7, donde N es el índice del día de la
                // semana, D es el día, M es la clave del mes, A son los últimos dos
                // dígitos del año y S es la clave del siglo.
                int mDiaSemana = (int)((this.iDia + CLAVE_MES[this.iMes - 1] + mAño + (mAño / 4) + mClaveSiglo) % 7);
                return DIA_SEMANA[mDiaSemana];
            }
        }
    }
}