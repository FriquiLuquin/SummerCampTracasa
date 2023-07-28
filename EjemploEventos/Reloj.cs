namespace EjemploEventos
{
    public class Reloj
    {
        // delegado
        public delegate void CambioSegundoDelegado(object reloj,
            InformacionTiempoEventArgs informacionTiempo);

        // Evento
        public event CambioSegundoDelegado CambioSegundoEvento;

        public Reloj()
        {
            
        }

        private int segundo;

        public void IniciarReloj()
        {
            DateTime fechaHoraActual;

            for (; ; )
            {
                Thread.Sleep(1000);
                fechaHoraActual = DateTime.Now;
                if (fechaHoraActual.Second != segundo)
                {
                    // Guardar info tiempo
                    var informacionTiempo = new InformacionTiempoEventArgs(
                                                    fechaHoraActual.Hour,
                                                    fechaHoraActual.Minute,
                                                    fechaHoraActual.Second);
                    // Lanzar evento
                    if (CambioSegundoEvento != null)
                    {
                        CambioSegundoEvento(this, informacionTiempo);
                    }
                }

                segundo = fechaHoraActual.Second;
            }
        }
    }
}