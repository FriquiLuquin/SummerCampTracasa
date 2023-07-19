namespace ConversorSimple
{
    internal class Conversor
    {
        public enum Divisas
        {
            Euros,
            Dolares,
            Libras
        }

        const double FactorEurosADolares = 1.12;
        const double FactorEurosALibras = 0.87;
        const double FactorDolaresAEuros = 0.89;
        const double FactorDolaresALibras = 0.77;
        const double FactorLibrasAEuros = 1.15;
        const double FactorLibrasADolares = 1.29;

        public static double ConvertirEntreDivisas(Divisas divisaOrigen, Divisas divisaDestino, double cantidad)
        {
            var resultado = 0d;

            switch ((divisaOrigen, divisaDestino))
            {
                case (Divisas.Euros, Divisas.Dolares):
                    resultado = cantidad * FactorEurosADolares;
                    break;
                case (Divisas.Euros, Divisas.Libras):
                    resultado = cantidad * FactorEurosALibras;
                    break;
                case (Divisas.Dolares, Divisas.Euros):
                    resultado = cantidad * FactorDolaresAEuros;
                    break;
                case (Divisas.Dolares, Divisas.Libras):
                    resultado = cantidad * FactorDolaresALibras;
                    break;
                case (Divisas.Libras, Divisas.Euros):
                    resultado = cantidad * FactorLibrasAEuros;
                    break;
                case (Divisas.Libras, Divisas.Dolares):
                    resultado = cantidad * FactorLibrasADolares;
                    break;
                default:
                    resultado = cantidad;
                    break;
            }

            return Math.Round(resultado, 2);
        }
    }
}
