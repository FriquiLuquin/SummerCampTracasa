using ApiJsonBiblioteca;
using AutoMapper;
using EjemploMVCConversor.Models;

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
