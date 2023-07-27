using EventosDelegadosLINQ.Medios;
using static EventosDelegadosLINQ.InventarioMedios;

namespace EventosDelegadosLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //++ 1-Crear instancias
            var inventarioMedios = new InventarioMedios();
            var reproductorCDs = new ReproductorCDs();
            var tocadiscos = new Tocadiscos();
            var videoVHS = new VideoVHS();

            //++ 2A-Crear instancias de delegados
            ProbarMediosDelegado probarCDDelegado =
                new ProbarMediosDelegado(reproductorCDs.ProbarCD);

            ProbarMediosDelegado probarViniloDelegado =
                new ProbarMediosDelegado(tocadiscos.ProbarVinilo);

            ProbarMediosDelegado probarVideoVHSDelegado =
                new ProbarMediosDelegado(videoVHS.ProbarVideoVHS);

            //++ 3A-Probar delegados
            inventarioMedios.ResultadoProbarMedios(probarCDDelegado);
            Console.WriteLine();
            inventarioMedios.ResultadoProbarMedios(probarViniloDelegado);
            Console.WriteLine();
            inventarioMedios.ResultadoProbarMedios(probarVideoVHSDelegado);
            Console.WriteLine();

            //++ 2B-Crear delegados Info
            InfoMediosDelegado infoCDDelegado =
                new InfoMediosDelegado(reproductorCDs.ObtenerCancionesCD);

            InfoMediosDelegado infoViniloDelegado =
                new InfoMediosDelegado(tocadiscos.ObtenerCancionesDisco);

            InfoMediosDelegado infoVideoVHSDelegado =
                new InfoMediosDelegado(videoVHS.ObtenerDatosPelicula);

            //++ 3B-Probar delegados Info
            inventarioMedios.ResultadoInfoMedios(infoCDDelegado, "idCD");
            Console.WriteLine();
            inventarioMedios.ResultadoInfoMedios(infoViniloDelegado, "idVinilo");
            Console.WriteLine();
            inventarioMedios.ResultadoInfoMedios(infoVideoVHSDelegado, "idVHS");
            Console.WriteLine();
        }
    }
}