namespace EjemploLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ejemploBasico = new EjemploBasico();
            ejemploBasico.Ejecutar();

            var ejemploOperador = new EjemploOperador();
            ejemploOperador.Ejecutar();
        }
    }
}