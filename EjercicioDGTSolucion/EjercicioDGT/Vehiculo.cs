namespace EjercicioDGT
{
    public class Vehiculo
    {
        public enum EtiquetaDGT{
            Sin,
            B,
            C,
            ECO,
            CERO
        }

        public Vehiculo()
        {
            
        }

        public Vehiculo(double impuestoBase, DateTime fechaMat, EtiquetaDGT etiqueta)
        {
            ImpuestoBase = impuestoBase;
            FechaMat = fechaMat;
            Etiqueta = etiqueta;
        }

        public double ImpuestoBase { get; set; }

        public DateTime FechaMat { get; set; }

        public EtiquetaDGT Etiqueta { get; set; }

        public double CalcularImpuestoCirculacion()
        {
            var antiguedad = DateTime.Now.Year - FechaMat.Year;
            var impuesto = ImpuestoBase + (ImpuestoBase * 0.01 * antiguedad);

            switch (Etiqueta)
            {
                case EtiquetaDGT.Sin:
                    impuesto += ImpuestoBase * 0.25;
                    break;

                case EtiquetaDGT.B:
                    impuesto += ImpuestoBase * 0.15;
                    break;

                case EtiquetaDGT.C:
                    impuesto += ImpuestoBase * 0.10;
                    break;

                case EtiquetaDGT.ECO:
                    impuesto += ImpuestoBase * 0.05;
                    break;

                case EtiquetaDGT.CERO:
                    // No suma nada
                    break;

                default:
                    break;
            }
            return impuesto;
        }
    }
}
