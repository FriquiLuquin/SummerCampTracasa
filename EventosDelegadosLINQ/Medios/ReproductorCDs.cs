using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventosDelegadosLINQ.Medios
{
    public class ReproductorCDs
    {
        public bool ProbarCD()
        {
            Console.WriteLine("Por favor, ponga el cd en el reproductor");
            Console.WriteLine("Pulse el boton de reproducción");
            Console.WriteLine("Indique a continuación si ha escuchado algo");
            var result = Console.ReadLine();

            return result == "S";
        }

        public string ObtenerCancionesCD(string codigoBarras)
        {
            // Buscar en BBDD codigoBarras
            // Devolver resultado
            return "Lista de canciones en la contraportada";
        }
    }
}
