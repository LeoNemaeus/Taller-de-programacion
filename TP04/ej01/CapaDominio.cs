﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej01
{
    class CapaDominio
    {
        public void Ejecutar ()
        {
            CapaPersistencia iCapaPersistencia = new CapaPersistencia();
            iCapaPersistencia.Ejecutar ();
        }
    }
}
