namespace EjercicioDGT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var vehiculo1 = new Vehiculo(1000, new DateTime(2015, 01, 01), Vehiculo.EtiquetaDGT.Sin);
            var vehiculo2 = new Vehiculo(1000, new DateTime(2018, 01, 01), Vehiculo.EtiquetaDGT.C);
            var vehiculo3 = new Vehiculo(1000, new DateTime(2020, 01, 01), Vehiculo.EtiquetaDGT.CERO);

            var lista = new List<Vehiculo>();
            lista.Add(vehiculo1);
            lista.Add(vehiculo2);
            lista.Add(vehiculo3);

            foreach (var vehiculo in lista) 
            {
                var impuesto = vehiculo.CalcularImpuestoCirculacion();
                Console.WriteLine($"El impuesto del vehiculo es {impuesto} euros");
            }
        }
    }
}