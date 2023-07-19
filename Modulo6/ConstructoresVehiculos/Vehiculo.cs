namespace ConstructoresVehiculos
{
    internal class Vehiculo
    {
        public Vehiculo(DateTime fechaCompra, string color)
        {
            FechaCompra = fechaCompra;
            Color = color;

        }

        public Vehiculo(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;

        }

        public Vehiculo(DateTime fechaCompra, string color, string marca, string modelo)
        {
            FechaCompra = fechaCompra;
            Color = color;
            Marca = marca;
            Modelo = modelo;

        }

        public DateTime FechaCompra { get; set; }

        public string Color { get; set; }

        public string Marca { get; set; }

        public string Modelo { get; set; }
    }
}
