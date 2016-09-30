using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4
{
	class Complejo
	{
		// Atributos
		private readonly var float iReal;
		private readonly var float iImaginario;
		// Constructores
		public Complejo(double pReal, double pImaginario)
		{
			iReal = pReal;
			iImaginario = pImaginario;
		}
		// Propiedades

		public double Real
		{ get { return iReal; } }
		public double Imaginario
		{ get { return iImaginario; } }
		public double ArgumentoEnRadianes
		{ get { return; } }
		public double ArgumentoEnGrados
		{ get { return; } }
		public double Magnitud
		{ get  { return; } }
		public Complejo Conjugado
		{ get { return ;} }
		// Métodos
		public bool EsReal()
		public bool EsImaginario()
		public bool EsIgual(Complejo pOtroComplejo)
		public Complejo Sumar(Complejo pOtroComplejo)
		public Complejo Restar(Complejo pOtroComplejo)
		public Complejo MultiplicarPor(Complejo pOtroComplejo)
		public Complejo DividirPor(Complejo pOtroComplejo)
}