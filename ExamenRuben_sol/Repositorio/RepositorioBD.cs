using Entidades;
using ContextoExamen;
using Microsoft.EntityFrameworkCore;

namespace Repositorio
{
    public class RepositorioBD:IRepositorioBD
    {
        private readonly ContextoExamen.ContextoExamen db;

        public RepositorioBD(ContextoExamen.ContextoExamen db)
        {
            this.db = db;
        }
        public async Task<List<Persona>> GetPersonaAsync() {

            var consulta =await db.Persona
           .OrderBy(persona => persona.Nombre)
           .ToListAsync();
            return consulta.Where(persona => CalcularEdad(persona.FechaNacimiento) > 21).Take(10).ToList();
            
        
        }
        public async Task RegistrarPersona(Persona persona) {
        
            db.Persona.Add(persona);
            await db.SaveChangesAsync();
        
        
        }




        static int CalcularEdad(DateTime fechaNacimiento)
        {
            // Calcular la edad a partir de la fecha de nacimiento.
            DateTime fechaActual = DateTime.Today;
            int edad = fechaActual.Year - fechaNacimiento.Year;

            // Ajustar la edad si aún no se ha celebrado el cumpleaños este año.
            if (fechaNacimiento > fechaActual.AddYears(-edad))
            {
                edad--;
            }

            return edad;
        }
    }
}