using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Herencia
{
    public class Administrador : Empleado
    {
        public Administrador(string nombre, bool tienePlazaParking/*,
                              int? numPlazaParking*/) : base(nombre)
        {
            TienePlazaParking = tienePlazaParking;
            // NumPlazaParking = numPlazaParking;
        }

        public bool TienePlazaParking { get; set; }
        // public int? NumPlazaParking { get; set; }
        public string PlazaParking()
        {
            // TODO: Conectar a Base de Datos
            throw new ErrorBaseDatosException("Error al conectar con la Base de Datos", DateTime.Now);
            return TienePlazaParking ? "Plaza A-1" : "No tiene plaza";
        }
        public override string ToString()
        {
            return $"Administrador. Nombre: {Nombre}, " +
                $"Dias de vacaciones: {diasVacaciones} ";
        }

        public override void CalculoVacaciones()
        {
            diasVacaciones += 9;
        }
    }
}