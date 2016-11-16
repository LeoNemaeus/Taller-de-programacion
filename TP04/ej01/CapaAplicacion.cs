using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej01
{
    public class CapaAplicacion
    {
             public void Ejecutar ()
             {
                 CapaDominio iCapaDominio = new CapaDominio();

                 try
                 {
                     iCapaDominio.Ejecutar();
                 }

                 catch (ErrorPuntualExcepcion e)
                 {
                     throw new CapaAplicacionExcepcion ("Se produjo una Excepción 2. " + e.Fecha);
                 }
             }
        }
  }

