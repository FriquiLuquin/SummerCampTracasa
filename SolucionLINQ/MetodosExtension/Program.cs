using Extensiones;

namespace MetodosExtension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var juan = "jUaN LoPeZ".ConvertirCadena();
            var luis = "LuIs mArTiNeZ".ConvertirCadena();
            Console.WriteLine(juan);
            Console.WriteLine(luis);

            int a = 1;
            int b = 2;
            if (a.EsMayorQue(b))
            {
                Console.WriteLine("Es mayor");
            }
            else
            {
                Console.WriteLine("No es mayor");
            }
        }
    }
}