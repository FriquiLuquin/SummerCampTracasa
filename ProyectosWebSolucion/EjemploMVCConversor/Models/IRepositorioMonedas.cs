﻿namespace EjemploMVCConversor.Models
{
    public interface IRepositorioMonedas
    {
        IEnumerable<Moneda> ObtenerMonedas();

        Moneda ObtenerMoneda(int id);

        void AgregarMoneda(Moneda moneda);

    }
}