using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ej04;

namespace Ej05
{
    class FabricaEncriptadores
    {
        //TERMINAR DE COMPLETAR LA CLASE TOMANDO COMO PARÁMETROS LOS CÓDIGOS DEL EJERCIO 4.
        private static FabricaEncriptadores cInstancia;
        private IDictionary<String, IEncriptador> iEncriptadores;
        private EncriptadorNulo Nulo = new EncriptadorNulo();

        private FabricaEncriptadores() { }

        public static FabricaEncriptadores Instancia
        {
            get { return cinstancia.Value; }
        }


    }
}
