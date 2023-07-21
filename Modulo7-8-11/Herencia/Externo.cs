using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Herencia
{
    public class Externo : Empleado
    {
        public Externo(string nombre, Empresa empresa) : base(nombre)
        {
            Empresa = empresa;
        }

        public Empresa Empresa { get; set; }

        public override string ToString()
        {
            return $"Externo. Nombre: {Nombre}, " +
                $"Dias de vacaciones: {diasVacaciones}, " +
                $"Empresa asociada: {Empresa} ";
        }

    }
}