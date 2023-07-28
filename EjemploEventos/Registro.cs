namespace EjemploEventos
{
    internal class Registro
    {
        public int Count { get; set; }
        public DateTime Tiempo1 { get; set; }

        public Registro()
        {
            Count = 0;
            Tiempo1 = DateTime.Now;
        }

        internal void Suscribir(Reloj reloj)
        {
            reloj.CambioSegundoEvento += Reloj_CambioSegundoEvento;
        }

        private void Reloj_CambioSegundoEvento(object reloj, InformacionTiempoEventArgs e)
        {
            //++ Contador
            /*
            Count++;

            if (Count == 10) 
            {
                Count = 0;
                Console.WriteLine($"FechaActual: {DateTime.Today.Day}/{DateTime.Today.Month}/{DateTime.Today.Year}" +
                    $" - Hora actual: {e.Hora}:{e.Minuto}:{e.Segundo}");
            }
            */

            //++ TimeSpan
            DateTime Tiempo2 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 
                                            e.Hora, e.Minuto, e.Segundo);
            var lapso = Tiempo2 - Tiempo1;

            if (lapso.TotalSeconds >= 10)
            {
                Tiempo1 = Tiempo2;
                Console.WriteLine($"FechaActual: {DateTime.Today.Day}/{DateTime.Today.Month}/{DateTime.Today.Year}" +
                    $" - Hora actual: {e.Hora}:{e.Minuto}:{e.Segundo}");
            }

        }
    }
}