using Entidades;

namespace Clases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear y asignar propiedades mediante la instancia
            var jose = new Empleado();
            jose.Nombre = "Jose";
            jose.Salario = 20000;
            jose.FechaAlta = new DateTime(2021, 01, 10);
            jose.Alta = true;

            // Crear y asignar valores a propiedades directamente
            var maria = new Empleado()
            {
                Nombre = "Maria",
                Salario = 20000,
                FechaAlta = new DateTime(2022, 03, 01),
                Alta = true
            };

            // Crear instancia y pasarle parametros al constructor
            var jesus = new Empleado("Jesus", 20000, new DateTime(2023, 01, 15), true);

            var lista = new List<Empleado>();
            lista.Add(maria);
            lista.Add(jose);
            lista.Add(jesus);

            foreach (var empleado in lista)
            {
                empleado.CalcularAumentoSalario();
            }

        }
    }
}