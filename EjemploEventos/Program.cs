namespace EjemploEventos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear la instancia del reloj interno (Publicador)
            var reloj = new Reloj();

            // Crear un reloj digital y suscribirnos (Subsriptor)
            var relojDigital = new RelojDigital();
            // relojDigital.Suscribir(reloj);

            // Ejercicio
            // Crear un log o registro que guarde cada 10 segundo la fecha y la hora
            var log = new Registro();
            log.Suscribir(reloj);

            // Poner en marcha el reloj
            reloj.IniciarReloj();
        }
    }
}