using System;

namespace Entidades
{
    /*
     * public - Visible en todo el proyecto
     * private - Visible dentro de la clase/struct
     * protected - Visible dentro de la clase o clase derivada
     * internal - Visible dentro del proyecto
     */
    public class Empleado
    {
        public Empleado()
        {

        }

        public Empleado(string nombre,
                        double salario,
                        DateTime fechaAlta,
                        bool alta)
        {
            Nombre = nombre;
            Salario = salario;
            FechaAlta = fechaAlta;
            Alta = alta;
        }

        public string Nombre { get; set; }

        public double Salario { get; set; }

        public DateTime FechaAlta { get; set; } = DateTime.Now;

        public bool Alta { get; set; }

        public void CalcularAumentoSalario()
        {
            // throw new NotImplementedException();
        }
    }
}
