namespace ConversorSimple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stringDivisaOrigen = string.Empty;
            var stringDivisaDestino = string.Empty;
            var stringCantidad = string.Empty;
            var stringExit = string.Empty;
            bool exit = false;

            Console.WriteLine("Bienvenido al conversor de divisas.");

            do
            {
                Console.WriteLine($"- {Conversor.Divisas.Euros}");
                Console.WriteLine($"- {Conversor.Divisas.Dolares}");
                Console.WriteLine($"- {Conversor.Divisas.Libras}");

                Console.Write("Introduce la divisa de origen: ");
                stringDivisaOrigen = Console.ReadLine();
                Enum.TryParse(stringDivisaOrigen, out Conversor.Divisas divisaOrigen);

                Console.Write("Introduce la divisa de destino: ");
                stringDivisaDestino = Console.ReadLine();
                Enum.TryParse(stringDivisaDestino, out Conversor.Divisas divisaDestino);

                Console.Write("Introduce la cantidad a convertir: ");
                stringCantidad = Console.ReadLine();
                Double.TryParse(stringCantidad, out var cantidad);

                var resultado = Conversor.ConvertirEntreDivisas(divisaOrigen, divisaDestino, cantidad);
                Console.WriteLine($"{cantidad} {divisaOrigen} equivalen a {resultado} {divisaDestino}");

                Console.WriteLine();
                Console.Write("¿Quieres hacer otra conversion? (y/n): ");
                stringExit = Console.ReadLine();
                if (!string.IsNullOrEmpty(stringExit) && !(stringExit.ToLower().StartsWith('y')))
                {
                    exit = true;
                }

            } while (!exit);

        }
    }
}