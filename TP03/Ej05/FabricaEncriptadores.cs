using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ej04;

namespace Ej05
{
    public class FabricaEncriptadores
    {
        private Dictionary<string, IEncriptador> iEncriptadores = new Dictionary<string, IEncriptador>();

        private static readonly Lazy<FabricaEncriptadores> cinstancia = new Lazy<FabricaEncriptadores>(() => new FabricaEncriptadores());

        private readonly EncriptadorNulo iEncriptadorNulo = new EncriptadorNulo();

        private FabricaEncriptadores()
        {


            foreach (Encriptador encriptador in new Encriptador[] { new EncriptadorCesar(3), new EncriptadorAES() })
            {
                this.iEncriptadores.Add(encriptador.Nombre, encriptador);
            }
        }

        public static FabricaEncriptadores Instancia
        {
            get { return cinstancia.Value; }
        }

        public IEncriptador GetEncriptadores(string nombre)
        {
            IEncriptador encriptador = this.iEncriptadorNulo;

            if (this.iEncriptadores.ContainsKey(nombre)) 
            {
                encriptador = this.iEncriptadores[nombre];
            }

            return encriptador;
        }
    }
}
