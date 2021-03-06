﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej03
{
    /// <summary>
    /// Representa un cliente. Mantiene el nombre y apellido, fecha de nacimiento, empleo y el tipo del cliente.
    /// </summary>
    public class Cliente
    {
        String iNombre, iApellido;
        DateTime iFechaNacimiento;
        Empleo iEmpleo;
        TipoCliente iTipoCliente;

        public Cliente(String pNombre, String pApellido, DateTime pFechaNacimiento, Empleo pEmpleo, TipoCliente pTipoCliente)
        {
            iNombre = pNombre;
            iApellido = pApellido;
            iFechaNacimiento = pFechaNacimiento;
            iEmpleo = pEmpleo;
            iTipoCliente = pTipoCliente;
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
