using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej05
{
    /// <summary>
    /// Representa una fecha entre el 01/01/1900 y el 31/12/2499.
    /// </summary>
    public class Fechas
    {
        /// <summary>
        /// Tomamos el año base como inicio desde el 1 de enero de 1900 y año máximo hasta el 31 de diciembre de 2499.
        /// </summary>
        private const int AÑO_BASE = 1900, AÑO_MAXIMO = 2499;

        /// <summary>
        /// El array cantidad_dias_mes contiene en cada posición la cantidad de dias de los doce meses del año
        /// teniendo en cuenta que febrero no es bisiesto.
        /// </summary>
        private static readonly int[] CANTIDAD_DIAS_MES = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        /// <summary>
        /// El array clave_mes contiene un número clave por cada mes del año.
        /// </summary>
        private static readonly int[] CLAVE_MES = { 0, 3, 3, 6, 1, 4, 6, 2, 5, 0, 3, 5 };

        /// <summary>
        /// El array clave_siglo parte desde la primera posición con clave 0 para el sigro XX, y sigue 
        /// asignadole claves a las demás posiciónes correspondientes hasta el siglo XV
        /// </summary>
        private static readonly int[] CLAVE_SIGLO = { 0, 6, 4, 2, 0, 6 };

        /// <summary>
        /// Contiene un array con los siete dias de la semana.
        /// </summary>
        private static readonly String[] DIA_SEMANA = { "Domingo", "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado" };

        /// <summary>
        /// Cantidad de días transcurridos desde la fecha base 
        /// </summary>
        private readonly long iCantidadDias;

        /// <summary>
        /// Componentes día de la fecha, componente mes de la fecha y componente año de la fecha. 
        /// </summary>
        private readonly int iDia, iMes, iAño;

        /// <summary>
        /// Componente dia de la fecha
        /// </summary>
        public int Dia
        {
            get { return this.iDia; }
        }

        /// <summary>
        /// Componente mes de la fecha
        /// </summary>
        public int Mes
        {
            get { return this.iMes; }
        }

        /// <summary>
        /// Componente año de la fecha
        /// </summary>
        public int Año
        {
            get { return this.iAño; }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="pDia">Componente dia. </param>
        /// <param name="pMes">Componente mes. </param>
        /// <param name="pAño">Componente año. </param>
        /// <exception cref="ArgumentException">Si <paramref name="pDia"/> no está comprendido entre 1 y la cantidad de días máximos del <paramref name="pMes"/> y <paramref name="pAño"/>. </exception>
        /// <exception cref="ArgumentException">Si <paramref name="pMes"/> no está comprendido entre 1 y 12. </exception>
        /// <exception cref="ArgumentException">Si <paramref name="PAño"/> no está comprendido entre 1900 y 2499. </exception> 

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

        /// <summary>
        /// Constructor interno al que se le pasan la cantidad de día.
        /// </summary>
        /// <<param name="pCantidadDias">Cantidad de días.</param>
        /// <exception cref="ArgumentException">Si <paramref name="pCantidadDias"/> no está comprendido entre 1 y 219.146.</exception>
        
        public Fechas(long pCantidadDias)
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

        /// <summary>
        /// Calcula la cantidad de dias tomando como parámetro un mes y un año
        /// </summary>
        /// <param name="pMes"> Mes para el que se desea calcular la cantidad de dias</param>
        /// <param name="pAño"> Año para el que se desea calcular la cantidad de dias</param>
        /// <returns>Devuelve en mCantidadDias la cantidad de dias a partir del mes y año. </returns>

        private static int CalcularCantidadDiasMes(int pMes, int pAño)
        {
            int mCantidadDias = CANTIDAD_DIAS_MES[pMes - 1];

            // Si el mes es febrero y el año es bisiesto entonces debo sumarle
            // una unidad al número recuperado.
            if (pMes == 2 && Fechas.EsBisiesto(pAño))
            {
                mCantidadDias += 1;
            }

            return mCantidadDias;
        }

        /// <summary>
        /// Calcula la cantidad de dias que hay en un año
        /// </summary>
        /// <param name="pAño"> Año ingresado para el cual se desean obtener la cantidad de dias</param>
        /// <returns> Devuelve la cantidad de dias teniendo en cuenta si el año ingresado es bisiesto o no. </returns>

        private static int CalcularCantidadDiasAño(int pAño)
        {
            int mCantidadDias = 365;

            if (Fechas.EsBisiesto(pAño))
            {
                mCantidadDias++;
            }

            return mCantidadDias;
        }

        /// <summary>
        /// Realiza el cálculo del año en caso de ser bisiesto.
        /// </summary>

        public static bool EsBisiesto(int pAño)
        {
            return (pAño % 4 == 0 || (pAño % 100 != 0 && pAño % 400 == 0));
        }


        /// <summary>
        /// Agregar  a una fecha la cantidad de dias ingresados como parámetro y devuelve una nueva instancia de la fecha resultante.
        /// </summary>
        /// <param name="pCantidadDias">Cantidad de dias que se quiere agregar</param>
        /// <returns> Devuelve una nueva instancia de agregar <param name="pCantidadDias">. </returns>
        public Fechas AgregarDias(int pCantidadDias)
        {
            return new Fechas(this.iCantidadDias + pCantidadDias);
        }
        
        /// <summary>
        /// Agregar a una fecha la cantidad de meses ingresados como parámetro y devuelve una nueva instancia de la fecha resultante. 
        /// </summary>
        /// <param name="pCantidadMeses">Cantidad de meses que se quieran agregar</param>
        /// <returns>Devuelve una nueva instancia de agregar <paramref name="pCantidadMeses"/>.</returns>
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

        /// <summary>
        /// Agregar a una fecha la cantidad de años ingresados como parámetro y devuelve una nueva instancia de la fecha resultante.
        /// </summary>
        /// <param name="pAños">Cantidad de meses que se quieran agregar</param>
        /// <returns> Devuelve una nueva instancia de agregar <paramref name="pAños"/>. </returns>
        public Fechas AgregarAños(int pAños)
        {
            int mCantidadDias = 0;

            for (int bIndice = 1; bIndice <= pAños; bIndice++)
            {

                mCantidadDias += Fechas.CalcularCantidadDiasAño(this.iAño + bIndice);
            }

            return new Fechas(this.iCantidadDias + mCantidadDias);
        }
        /// <summary>
        /// Indica si la fecha pertenece a un año bisiesto.
        /// </summary>
        /// <returns>true si la fecha pertenece a un año bisiesto, false en caso contrario.</returns>
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

        /// <summary>
        /// Compara la fecha con la provista como parámetro.
        /// </summary>
        /// <param name="pFecha">Fecha ingresada con la que se quiere comparar.</param>
        /// <returns>-1 si la fecha es menor que la fecha provista, 0 si son iguales, y 1 si la fecha es mayor a la fecha proporcionada como parámetro.</returns>
        /// <exception cref="ArgumentNullException">Si <paramref name="pFecha"/> es nula.</exception>
        public int CompararFecha(Fechas pFecha)
        {

            if (pFecha == null)
            {
                throw new ArgumentNullException("La fecha proporcionada es nula.");
            }

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

        
    }
}