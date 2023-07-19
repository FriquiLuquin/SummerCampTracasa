using System.Runtime.Intrinsics;

namespace ConstructoresVehiculos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Construir vehiculo con fecha de compra y color
            var v1 = new Vehiculo(new DateTime(2020, 01, 01), "Blanco");

            // Construir vehiculo con marca y modelo
            var v2 = new Vehiculo("Tesla", "X");

            // Construir vehiculo con fecha de compra, color, marca y modelo
            var v3 = new Vehiculo(new DateTime(2020, 01, 01), "Gris", "Dacia", "Duster");

            var lista = new List<Vehiculo>();
            lista.Add(v1);
            lista.Add(v2);
            lista.Add(v3);

            foreach (var v in lista)
            {
                if (!string.IsNullOrEmpty(v.Marca) && !string.IsNullOrEmpty(v.Modelo))
                {
                    Console.WriteLine($"El vehiculo es un {v.Marca} {v.Modelo}");
                }
                if (!string.IsNullOrEmpty(v.Color)) { Console.WriteLine($"El vehiculo es de color {v.Color}"); }
                if (v.FechaCompra != DateTime.MinValue) { Console.WriteLine($"El vehiculo se compro en {v.FechaCompra}"); }
                Console.WriteLine();
            }

        }
    }
}