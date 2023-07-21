using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Herencia
{
    public class Trabajador : Empleado
    {
        public Trabajador(string nombre, string turno) : base(nombre)
        {
            Turno = turno;
        }

        public string Turno { get; set; }

        public override string ToString()
        {
            return $"Trabajador. Nombre: {Nombre}, " +
                $"Dias de vacaciones: {diasVacaciones} ";
        }

        public override void CalculoVacaciones()
        {
            base.CalculoVacaciones();
            diasVacaciones += 15;
        }


    }
}