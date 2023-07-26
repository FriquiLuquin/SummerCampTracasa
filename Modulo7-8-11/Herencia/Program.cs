namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EJERCICIO 1

            Empleado juan = new Empleado("Juan");

            Empleado maria = new Administrador("Maria", true);

            juan.Jefe = maria;

            Object jose = new Trabajador("Jose", "mañanas");

            Console.WriteLine(juan.ToString());
            Console.WriteLine(maria.ToString());
            Console.WriteLine(jose.ToString());
            Console.WriteLine();

            // EJERCICIO 2

            Empresa empresa = new Empresa("GLOBEX INC.");
            Empleado jesus = new Externo("Jesus", empresa);
            Console.WriteLine(jesus.ToString());
            Console.WriteLine();


            Empleado jorge = new Administrador("Jorge", false);
            Empleado lucia = new Trabajador("Lucia", "tardes");
            Empleado jennifer = new Empleado("Jennifer");

            var lista = new List<Empleado>()
            {
                juan, maria, (Trabajador) jose, jesus, jorge, lucia, jennifer
            };

            // Usando foreach
            foreach (var empleado in lista)
            {
                if (empleado.Nombre.StartsWith("J") || empleado.Nombre.StartsWith("j"))
                {
                    empleado.CalculoVacaciones();
                    Console.WriteLine(empleado);
                }
            }
            Console.WriteLine();

            // Usando LINQ
            var listaEmpleadosJ = from empleado in lista
                                  where empleado.Nombre.StartsWith("J") || empleado.Nombre.StartsWith("j")
                                  orderby empleado.Nombre
                                  select empleado;

            foreach (var empleado in listaEmpleadosJ)
            {
                empleado.CalculoVacaciones();
                Console.WriteLine(empleado);
            }
            Console.WriteLine();

            // EJERCICIO 3

            try
            {
                if (((Administrador)maria).TienePlazaParking)
                {
                    Console.WriteLine(((Administrador)maria).PlazaParking()); // Lanza exception
                }
            }
            catch (ErrorBaseDatosException ex)
            {
                Console.WriteLine($"{ex.Message}. {ex.FechaHoraExcepcion}");
            }
            Console.WriteLine();

            // EJERCICIO 4

            foreach (var empleado in lista)
            {
                var tipo = empleado.GetType().Name;
                Console.Write(tipo + ": ");

                switch (tipo)
                {
                    case "Trabajador":
                        // TODO: Mostrar turno
                        var trabajador = (Trabajador)empleado;
                        Console.WriteLine(trabajador.Turno);
                        break;
                    case "Administrador":
                        // TODO: Mostrar plaza de parking
                        var administrador = (Administrador)empleado;
                        try
                        {
                            Console.WriteLine(administrador.PlazaParking());
                        }
                        catch (ErrorBaseDatosException ex)
                        {
                            Console.WriteLine($"{ex.Message}. {ex.FechaHoraExcepcion}");
                        }
                        break;
                    case "Externo":
                        // TODO: Mostrar nombre de la empresa
                        var externo = (Externo)empleado;
                        Console.WriteLine(externo.Empresa);
                        break;
                    default:
                        Console.WriteLine();
                        break;
                }
            }
            Console.WriteLine();
        }
    }
}