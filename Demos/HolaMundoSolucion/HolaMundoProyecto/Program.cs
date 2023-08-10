namespace HolaMundoProyecto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? nombre = "Juan".ToUpper();
            // nombre = nombre.ToUpper();
            nombre = null;

            try
            {
                Console.WriteLine("Hola, Mundo! Me llamo " + nombre.ToUpper());
            }
            catch (Exception)
            {
                Console.WriteLine("Error!!!");
                // throw;
            }
        }
    }
}