using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// TODO: iEmpleo debería ser una lista? por la composición viteh.

namespace ej03
{
    public class Cliente
    {
        String iNombre, iApellido;
        DateTime iFechaNacimiento;
        Empleo iEmpleo;
        TipoCliente iTipoCliente;

        public Cliente(String pNombre, String pApellido, String pFechaNacimiento, Empleo pEmpleo)
        {
            iNombre = pNombre;
            iApellido = pApellido;
            iFechaNacimiento = Convert.ToDateTime(pFechaNacimiento);
            iEmpleo = pEmpleo;
        }

        public String Nombre
        { get { return iNombre; } }

        public String Apellido
        { get { return iApellido; } }

        public DateTime FechaNacimiento
        { get { return iFechaNacimiento; } }

        public TipoCliente TipoCliente
        {
            get { return iTipoCliente; }
            set { iTipoCliente = value; }
        }

        public Empleo Empleo
        { get { return iEmpleo; } }
    }
}
