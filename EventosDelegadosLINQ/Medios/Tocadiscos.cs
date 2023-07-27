using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventosDelegadosLINQ.Medios
{
    public class Tocadiscos
    {
        public bool ProbarVinilo()
        {
            Console.WriteLine("Por favor, ponga el vinilo en el reproductor");
            Console.WriteLine("Indique a continuación si ha escuchado algo");
            var result = Console.ReadLine();

            return result == "S";
        }

        public string ObtenerCancionesDisco(string codigoBarras)
        {
            // Buscar en BBDD codigoBarras
            // Devolver resultado
            return "Lista de canciones estan en la contraportada";
        }
    }
}
