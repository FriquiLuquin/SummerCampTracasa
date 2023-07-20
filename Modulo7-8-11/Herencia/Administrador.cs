﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Herencia
{
    public class Administrador : Empleado
    {
        public Administrador(string nombre) : base(nombre)
        {
        }

        public override string ToString()
        {
            return $"Administrador. Nombre: {Nombre}, " +
                $" Dias de vacaciones: {diasVacaciones} ";
        }
    }
}