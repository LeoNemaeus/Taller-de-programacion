﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej04
{
    class EncriptadorAES : Encriptador
    {
        private int iDesplazamiento;

        public EncriptadorAES()
        {

        }

        public override string Encriptar(string pCadena)
        {
            return pCadena; //TODO: buscar en wikipedia encriptacion AES
        }
        public override string Desencriptar(string pCadena)
        {
            return pCadena;
        }
    }
}
