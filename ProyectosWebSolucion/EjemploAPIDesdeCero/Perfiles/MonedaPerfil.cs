using AutoMapper;
using Biblioteca;

namespace EjemploAPIDesdeCero.Perfiles
{
    public class MonedaPerfil : Profile
    {
        public MonedaPerfil()
        {
            CreateMap<Moneda, MonedaDto>();
            CreateMap<Moneda, MonedaAltaDto>();
            CreateMap<MonedaAlta, Moneda>();
        }
    }
}
