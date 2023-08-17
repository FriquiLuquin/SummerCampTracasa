using ApiJsonBiblioteca;
using AutoMapper;
using Biblioteca;

namespace EjemploMvcConversor.Profiles
{
    public class MonedaProfile : Profile
    {
        public MonedaProfile()
        {
            CreateMap<MonedaJson, Moneda>();
        }
    }
}
