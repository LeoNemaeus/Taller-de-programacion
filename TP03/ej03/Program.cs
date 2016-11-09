using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *  - Existen cuatro tipos de clientes, siendo los mismos de menor a mayor categoría No Cliente, Cliente, Cliente Gold y Cliente Platinum.
 *  - Los requisitos para la solicitud de préstamos son:
 *       - Tener entre 18 y 75 años, como mínimo 6 meses de antigüedad laboral y un sueldo mínimo de $5.000.
 *       - Los clientes del tipo No cliente pueden solicitar hasta $20.000 en un máximo de 12 cuotas.
 *       - Los clientes del tipo Cliente pueden solicitar hasta $100.000 en un máximo de 32 cuotas.
 *       - Los clientes del tipo Cliente Gold pueden solicitar hasta $150.000 en un máximo de 60 cuotas.
 *       - Los clientes del tipo Cliente Premium pueden solicitar hasta $200.000 en un máximo de 60 cuotas.
 *   - Para que una solicitud de préstamo sea válida, se deben cumplir todos los requisitos anteriormente enumerados acorde al tipo de cliente que realiza la solicitud.
 */


namespace ej03
{
    class Program
    {
        static void Main(string[] args)
        {
            Shell.display();
        }
    }
}
