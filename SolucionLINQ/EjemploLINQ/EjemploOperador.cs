using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EjemploLINQ.Empleado;

namespace EjemploLINQ
{
    public class EjemploOperador
    {
        public EjemploOperador()
        {

        }

        public void Ejecutar()
        {
            // Lista de empleados
            IEnumerable<Empleado> Empleados = new List<Empleado>()            {                 new Empleado                 {                     Nombre = "Jose",                     Apellidos = "Coronado",                     Ciudad = "Madrid",                     Telefono = "123456789",                     Departament = Departamento.Admin                 },                 new Empleado                 {                     Nombre = "Luis",                     Apellidos = "Conde",                     Ciudad = "Madrid",                     Telefono = "423456789",                     Departament = Departamento.Desarrollo                 },                 new Empleado                 {                     Nombre = "Juan",                     Apellidos = "Nuñez",                     Ciudad = "Barcelona",                     Telefono = "9123456789",                     Departament = Departamento.Desarrollo                 },                 new Empleado                 {                     Nombre = "Maria",                     Apellidos = "Castillo",                     Ciudad = "Valencia",                     Telefono = "8123456789",                     Departament = Departamento.Soporte                 }            };

            // Define una list consulta LINQ con los empleados definidos anteriormente donde:
            // El Departamento sea Desarrollo o Soporte
            // El apellido empiece por C
            // Devuelve el resultado en orden descendente por nombre en una lista

            List<Empleado> empleadosDesarrolloSoporte = Empleados
                                             .Where(empleado =>
                                                       (empleado.Departament == Departamento.Desarrollo ||
                                                       empleado.Departament == Departamento.Soporte)
                                                        && empleado.Apellidos.StartsWith("C")
                                                    )
                                             .OrderByDescending(empleado => empleado.Nombre)
                                             .Select(empleado => empleado)
                                             .ToList();
            mostrarLista(empleadosDesarrolloSoporte);

            List<Empleado> empleadosDesarrolloSoporteConsulta = (from empleado in Empleados
                                                                 where (empleado.Departament == Departamento.Desarrollo ||
                                                                   empleado.Departament == Departamento.Soporte)
                                                                   && empleado.Apellidos.StartsWith("C")
                                                                 orderby empleado.Nombre descending
                                                                 select empleado).ToList();
            mostrarLista(empleadosDesarrolloSoporteConsulta);


            // Listado de los telefonos de los empleados de Madrid
            // que contengan en su apellido una "a"
            // ordenado por nombre

            var empleadosTelefonos = Empleados.Where(empleado => (empleado.Ciudad == "Madrid" &&
                                                                  empleado.Apellidos.Contains("a")))
                                              .OrderBy(empleado => empleado.Nombre)
                                              .Select(empleado => empleado.Telefono)
                                              .ToList();

            var empleadosTelefonosConsulta = (from empleado in Empleados
                                              where empleado.Ciudad.Equals("Madrid") && empleado.Apellidos.Contains("a")
                                              orderby empleado.Nombre ascending
                                              select new { Telefono = empleado.Telefono, Ciudad = empleado.Ciudad })
                                             .ToList();


            // Agregar esta lista a los antiguos empleados
            // No se permite el uso de Lista.Add
            // Se agregan todos de una vez

            var empleadosNuevos = new List<Empleado>            {                new Empleado                {                    Nombre = "Fabricio",                    Apellidos = "Cordero",                    Departament = Departamento.Desarrollo                },                new Empleado                {                    Nombre = "Julia",                    Apellidos = "Lombardo",                    Departament = Departamento.Admin                },            };

            Empleados = Empleados.Union(empleadosNuevos).ToList();
            mostrarLista((List<Empleado>)Empleados);
        }

        private void mostrarLista(List<Empleado> lista)
        {
            foreach (var elem in lista)
            {
                Console.WriteLine(elem.Nombre);                Console.WriteLine(elem.Apellidos);                Console.WriteLine(elem.Ciudad);                Console.WriteLine(elem.Telefono);                Console.WriteLine(elem.Departament);
            }
            Console.WriteLine();
        }
    }
}
