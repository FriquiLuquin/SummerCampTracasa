using AutoMapper;
using DTOs;
using Entidades;

namespace Perfiles
{
    public class PersonaProfile:Profile
    {
        public PersonaProfile()
        {
            CreateMap<Persona, PersonaDTO>();
            CreateMap<Persona, PersonaDTO>().ReverseMap();

        }
        
    }
}