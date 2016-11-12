using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej04
{
    class Fachada
    {
        public static FabricaEncriptadores instanciarFabrica()

            // aca es en donde mas hay que tocar cosas.
            // hay que linkear la interfaz con los metodos de aca y con ENCRIPTAR() y
            // DESENCRIPTAR() de los encriptadores (que se devuelven desde el diccionario)
        {
            return FabricaEncriptadores.Instancia;
        }
        //IEncriptador encriptador

        public static string Encriptar(string nombreEncriptador, string frase)
        {
            IEncriptador encriptador = FabricaEncriptadores.Instancia.GetEncriptadores(nombreEncriptador);
            return encriptador.Encriptar(frase);
            
        }

        public static string Desencriptar(string nombreEncriptador, string frase)
        {
            IEncriptador encriptador = FabricaEncriptadores.Instancia.GetEncriptadores(nombreEncriptador);
            return encriptador.Desencriptar(frase);
        }
    }
}
