using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej04
{
	class Complejo
	{
		double readonly iReal, iImaginario;

		public Complejo(double pReal, double pImaginario)
		{
			iReal = pReal;
			iImaginario = pImaginario;
		}

		public readonly double Real
		{
			get { return iReal; }
		}
		public readonly double Imaginario
		{
			get { return iImaginario; }
		}
		public readonly double ArgumentoEnRadianes
		{
			get {}
		}
		public readonly double ArgumentoEnGrados
		{
			get {}
		}
		public readonly double ComplejoConjugado
		{
			get {}
		}
		public readonly double Magnitud
		{
			get {}
		}

		//Métodos
		public bool EsReal() {}
		public bool EsImaginario() {}
		public bool EsIgual(Complejo pOtroComplejo) {}
		public bool EsIgual(double pReal, double pImaginario) {}
		public Complejo Sumar(Complejo pOtroComplejo)
		{
			double mA = iReal + pOtroComplejo.Real;
			double mB = iImaginario + pOtroComplejo.Imaginario;

			return new Complejo(mA, mB);
		}
		public Complejo Restar(Complejo pOtroComplejo)
		{
			double mA = iReal - pOtroComplejo.Real;
			double mB = iImaginario - pOtroComplejo.Imaginario;

			return new Complejo(mA, mB);
		}
		public Complejo MultiplicarPor(Complejo pOtroComplejo)
		{
			double mA = (iReal * pOtroComplejo.Real) -
				(iImaginario * pOtroComplejo.Imaginario);
			double mB = (iReal * pOtroComplejo.Imaginario) +
				(iImaginario * pOtroComplejo.Real);
			 return new Complejo(mA, mB);
		}
		public Complejo DividirPor(Complejo pOtroComplejo)
		{
			double mA = ((iReal * pOtroComplejo.Real) +
							(iImaginario * pOtroComplejo.Imaginario);
			double mB = (iImaginar)
			return new Complejo(mA / (Math.Pow(pOtroComplejo.Real, 2) +
								Math.Pow(pOtroComplejo.Imaginario, 2)),
							mB / (Math.Pow(pOtroComplejo.Real, 2) +
								Math.Pow(pOtroComplejo.Imaginario, 2)));
		}
	}
}