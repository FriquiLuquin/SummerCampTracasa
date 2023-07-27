using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventosDelegadosLINQ.Medios
{
    public class VideoVHS
    {
        public bool ProbarVideoVHS()
        {
            Console.WriteLine("Por favor, ponga la cinta en el reproductor");
            Console.WriteLine("Indique a continuación si ha visto algo");
            var result = Console.ReadLine();

            return result == "S";
        }

        public string ObtenerDatosPelicula(string codigoBarras)
        {
            // Buscar en BBDD codigoBarras
            // Devolver resultado
            return "Los datos de la pelicula estan en la trasera de la caja";
        }
    }
}
