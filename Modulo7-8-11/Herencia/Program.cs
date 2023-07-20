namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado juan = new Empleado("Juan");

            Empleado maria = new Administrador("Maria");

            juan.Jefe = maria;

            Object jose = new Trabajador("Jose");

            Console.WriteLine(juan.ToString());
            Console.WriteLine(maria.ToString());
            Console.WriteLine(jose.ToString());
        }
    }
}