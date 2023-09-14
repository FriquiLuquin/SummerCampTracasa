using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public interface IRepositorioBD
    {
        Task<List<Persona>> GetPersonaAsync();
        Task RegistrarPersona(Persona persona);
    }
}
