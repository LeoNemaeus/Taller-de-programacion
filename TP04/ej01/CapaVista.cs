using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej01
{
    class CapaVista
    {
        public void Ejecutar ()
        {
            CapaControlador iCapaControlador = new CapaControlador();
            try
            {
                iCapaControlador.Ejecutar ();
            }
            catch (CapaAplicacionExcepcion e)
            {

                Console.WriteLine (e.Message);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
