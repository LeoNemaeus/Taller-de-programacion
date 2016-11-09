using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej04
{
    public class FabricaEncriptadores
    {
        private Dictionary<string, IEncriptador> iEncriptadores = new Dictionary<string, IEncriptador>();

        private static readonly Lazy<FabricaEncriptadores> cinstancia = new Lazy<FabricaEncriptadores>(() => new FabricaEncriptadores());

        private readonly EncriptadorNulo iEncriptadorNulo = new EncriptadorNulo();

        private FabricaEncriptadores()
        {
            //Encriptador encriptador = new EncriptadorCesar(3);

            //iEncriptadores.Add(encriptador.Nombre, encriptador);

            //encriptador = new EncriptadorAES();

            //iEncriptadores.Add(encriptador.Nombre, encriptador);

            foreach (Encriptador encriptador in new Encriptador[] { new EncriptadorCesar(3), new EncriptadorAES() })
            {
                this.iEncriptadores.Add(encriptador.Nombre, encriptador); // iniciamos los encriptadores
            }
        }

        public static FabricaEncriptadores Instancia
        {
            get { return cinstancia.Value; }
        }

        public IEncriptador GetEncriptadores(string nombre)
        {
            IEncriptador encriptador = this.iEncriptadorNulo;

            if (this.iEncriptadores.ContainsKey(nombre)) // esto esta bien asi, no lo toquen, lo hizo el profe
            {
                encriptador = this.iEncriptadores[nombre];
            }

            return encriptador;
        }
    }
}
 