using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploLINQ
{
    public class EjemploBasico
    {
        public EjemploBasico()
        {

        }

        public void Ejecutar()
        {
            string[] niveles = { "Basico", "Intermedio", "Avanzado" };
            int nc = niveles.Count();

            // Selecciona todos los niveles cuya longitud en caracteres sea mayor que 6
            // ordenado por nivel

            // FOREACH
            var listaResultados = new List<string>();
            foreach (var nivel in niveles)
            {
                if (nivel.Length > 6)
                {
                    listaResultados.Add(nivel);
                }
            }


            // Sintaxis SQL
            // select nivel from niveles where nivel.length > 6 order by nivel

            // 1. Preparacion
            var consultaLinq = from nivel in niveles
                               where nivel.Length > 6
                               orderby nivel
                               select nivel;
            // 2. Obtener resultados
            List<string> listaResultadosLinq = consultaLinq.ToList();
            mostrarLista(listaResultadosLinq);


            // Sintaxis de metodos

            // 1. Preparacion
            //var consultaLinqMetodos = niveles.Where((nivel) => { return nivel.Length > 6; });
            //Func<string, bool> predicado = nivel => nivel.Length > 6
            //var consultaLinqMetodos = niveles.Where(predicado);
            var consultaLinqMetodos = niveles.Where(nivel => nivel.Length > 6)
                                             .OrderBy(nivel => nivel)
                                             .Select(nivel => nivel);
            // 2. Resultados
            var listaResultadosLinqMetodos = consultaLinqMetodos.ToList();
            mostrarLista(listaResultadosLinqMetodos);

        }

        private void mostrarLista(List<string> lista)
        {
            foreach(var elem in lista)
            {
                Console.WriteLine(elem);
            }
            Console.WriteLine();
        }
    }
}
