using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventosDelegadosLINQ
{
    public class InventarioMedios
    {
        public delegate bool ProbarMediosDelegado();

        public delegate string InfoMediosDelegado(string id);

        public void ResultadoProbarMedios(ProbarMediosDelegado probarMediosDelegado)
        {
            var resultadoPrueba = probarMediosDelegado();

            if (resultadoPrueba)
            {
                Console.WriteLine("El método funciona, hay que agregarlo al inventario");
            }
            else
            {
                Console.WriteLine("El método no funciona, hay que destruirlo");
            }
        }

        public void ResultadoInfoMedios(InfoMediosDelegado infoMediosDelegado, string id)
        {
            var resultadoInfo = infoMediosDelegado(id);

            Console.WriteLine(resultadoInfo);
        }
    }
}
