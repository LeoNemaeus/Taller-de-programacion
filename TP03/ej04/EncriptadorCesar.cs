﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej04
{
    class EncriptadorCesar : Encriptador
    {
        private int iDesplazamiento;
        
        public EncriptadorCesar(int pDesplazamiento)
        {

        }

        public override string Encriptar(string pCadena)
        {
            return pCadena; //TODO: buscar en wikipedia encriptacion cesar
        }
        public override string Desencriptar(string pCadena)
        {
            return pCadena;
        }
    }
}
