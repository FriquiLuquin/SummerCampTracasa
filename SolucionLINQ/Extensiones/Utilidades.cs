namespace Extensiones
{
    public static class Utilidades
    {
        // Metodo de Extension
        public static string ConvertirCadena(this string cadena)
        {
            return cadena.Trim().ToUpper() + ".";
        }

        public static bool EsMayorQue(this int numero1, int numero2)
        {
            return numero1 > numero2;
        }
    }
}