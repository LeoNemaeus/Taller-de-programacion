using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    public class Fecha
    {


        private const int AÑO_BASE = 1900, AÑO_MAXIMO = 2499;

        private static readonly int[] CANTIDAD_DIAS_MES = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        private static readonly int[] CLAVE_MES = { 0, 3, 3, 6, 1, 4, 6, 2, 5, 0, 3, 5 };

        private static readonly int[] CLAVE_SIGLO = { 0, 6, 4, 2, 0, 6 };

        private static readonly String[] DIA_SEMANA = { "Domingo", "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado" };

        private readonly long iCantidadDias;
        private readonly int iDia, iMes, iAño;
        // Controla la fecha completa como parámetro de entrada le pasa el dia, mes y año.
        // Primero controla que el parámtro año ingresado sea menor que el AÑO_BASE o
        // que el año  ingresado como parámetro sea mayor al AÑO_MÁXIMO.
        // Luego controla que el mes esté dentro del rango [1 a 12]. 
        // Y que día sea mayor a 1 o dia menor a cantidad de dias mes restantes.
        public Fecha(int pDia, int pMes, int pAño)
        {
            if ((pAño < AÑO_BASE || pAño > AÑO_MAXIMO) && (pMes < 1 || pMes > 12) && (pDia < 1 || pDia > Fecha.CalcularCantidadDiasMes(pMes, pAño)))
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
                    mCantidadDias += Fecha.CalcularCantidadDiasMes(bMes, pAño);
                }

                // Se calculan la cantidad de días transcurridos desde el año base
                // hasta el año anterior al del componente año, ya que se han sumado
                // los días y meses de dicho año.
                for (int bAño = AÑO_BASE; bAño < pAño; bAño++)
                {
                    mCantidadDias += Fecha.CalcularCantidadDiasAño(bAño);
                }

                this.iCantidadDias = mCantidadDias;
            }
            else
            {
                this.iDia = 1;
                this.iMes = 1;
                this.iAño = AÑO_BASE;
                this.iCantidadDias = 1;
            }
        }

        private Fecha(long pCantidadDias)
        {

            if (pCantidadDias < 1 || pCantidadDias > 219146)
            {

                this.iCantidadDias = pCantidadDias;

                int mAñoActual = AÑO_BASE;

                int mCantidadDiasAñoActual = Fecha.CalcularCantidadDiasAño(mAñoActual);

                // Se van sumando años al año base siempre y cuando la cantidad de días
                // sea suficiente para el año que se quiera sumar.
                while (pCantidadDias > mCantidadDiasAñoActual)
                {
                    mAñoActual++;
                    pCantidadDias -= mCantidadDiasAñoActual;
                    mCantidadDiasAñoActual = Fecha.CalcularCantidadDiasAño(mAñoActual);
                }

                this.iAño = mAñoActual;

                int mMesActual = 1;

                int mCantidadDiasMesActual = Fecha.CalcularCantidadDiasMes(mMesActual, this.iAño);

                // Se van sumando meses siempre y cuando haya suficientes días para
                // el mes que se esté tratando.
                while (pCantidadDias > mCantidadDiasMesActual)
                {
                    mMesActual++;
                    pCantidadDias -= mCantidadDiasMesActual;
                    mCantidadDiasMesActual = Fecha.CalcularCantidadDiasMes(mMesActual, this.iAño);
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

        private static int CalcularCantidadDiasMes(int pMes, int pAño)
        {
            int mCantidadDias = CANTIDAD_DIAS_MES[pMes - 1];

            // Si el mes es febrero y el año no es bisiesto entonces debo quitarle
            // una unidad al número recuperado.
            if (pMes == 2 && !Fecha.EsBisiesto(pAño))
            {
                mCantidadDias -= 1;
            }

            return mCantidadDias;
        }

        private static int CalcularCantidadDiasAño(int pAño)
        {
            int mCantidadDias = 365;

            if (Fecha.EsBisiesto(pAño))
            {
                mCantidadDias++;
            }

            return mCantidadDias;
        }

        private static bool EsBisiesto(int pAño)
        {
            return pAño % 4 == 0 || (pAño % 100 != 0 && pAño % 400 == 0);
        }
        public Fecha AgregarDias(int pCantidadDias)
        {
            return new Fecha(this.iCantidadDias + pCantidadDias);
        }
        public Fecha AgregarMeses(int pCantidadMeses)
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

                mCantidadDias += Fecha.CalcularCantidadDiasMes(mMesActual, mAñoActual);
            }

            return new Fecha(this.iCantidadDias + mCantidadDias);
        }
        public Fecha AgregarAños(int pAños)
        {
            int mCantidadDias = 0;

            for (int bIndice = 1; bIndice <= pAños; bIndice++)
            {

                mCantidadDias += Fecha.CalcularCantidadDiasAño(this.iAño + bIndice);
            }

            return new Fecha(this.iCantidadDias + mCantidadDias);
        }
        public bool EsBisiesto()
        {
            return Fecha.EsBisiesto(this.iAño);
        }
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
        /// <summary>
        /// Componente día de la fecha.
        /// </summary>
        public int Dia
        {
            get { return this.iDia; }
        }

        /// <summary>
        /// Componente mes de la fecha.
        /// </summary>
        public int Mes
        {
            get { return this.iMes; }
        }

        /// <summary>
        /// Componente año de la fecha.
        /// </summary>
        public int Año
        {
            get { return this.iAño; }
        }

        /// <summary>
        /// Compara la fecha con la provista como parámetro.
        /// </summary>
        /// <param name="pFecha">Fecha con la que se quiere comparar.</param>
        /// <returns>-1 si la fecha es menor que la fecha provista, 0 si son iguales, y 1 si la fecha es mayor a la fecha proporcionada como parámetro.</returns>
        /// <exception cref="ArgumentNullException">Si <paramref name="pFecha"/> es nula.</exception>
        public int CompararFecha(Fecha pFecha)
        {

            if (pFecha == null)
            {

                int mResultado;

                if (this.iCantidadDias < pFecha.iCantidadDias)
                {
                    mResultado = -1;
                }
                else if (this.iCantidadDias == pFecha.iCantidadDias)
                {
                    mResultado = 0;
                }
                else
                {
                    mResultado = 1;
                }

                return mResultado;
            }
            else
                return -1;
        }

        public override String ToString()
        {
            return String.Format("{0}/{1}/{2}", this.iDia.ToString("D2"), this.iMes.ToString("D2"), this.iAño);
        }

    }
}

// String.Format permite darle formato a una cadena de caracteres.
