using Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContextoExamen
{
    public class ContextoExamen:DbContext
    {
        public ContextoExamen(DbContextOptions<ContextoExamen> options) : base(options) {



        }
         
         public DbSet<Persona> Persona { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            List<Persona> personas = new List<Persona>
        {
            new Persona { Id = 1, Nombre = "Juan", FechaNacimiento = new DateTime(2000, 1, 1), Telefono = "123-456-7891" },
            new Persona { Id = 2, Nombre = "María", FechaNacimiento = new DateTime(1995, 2, 2), Telefono = "123-456-7892" },
            new Persona { Id = 3, Nombre = "Pedro", FechaNacimiento = new DateTime(1990, 3, 3), Telefono = "123-456-7893" },
            new Persona { Id = 4, Nombre = "Ana", FechaNacimiento = new DateTime(1985, 4, 4), Telefono = "123-456-7894" },
            new Persona { Id = 5, Nombre = "Luis", FechaNacimiento = new DateTime(1980, 5, 5), Telefono = "123-456-7895" },
            new Persona { Id = 6, Nombre = "Laura", FechaNacimiento = new DateTime(1975, 6, 6), Telefono = "123-456-7896" },
            new Persona { Id = 7, Nombre = "Carlos", FechaNacimiento = new DateTime(1970, 7, 7), Telefono = "123-456-7897" },
            new Persona { Id = 8, Nombre = "Elena", FechaNacimiento = new DateTime(1965, 8, 8), Telefono = "123-456-7898" },
            new Persona { Id = 9, Nombre = "Isabel", FechaNacimiento = new DateTime(1960, 9, 9), Telefono = "123-456-7899" },
            new Persona { Id = 10, Nombre = "David", FechaNacimiento = new DateTime(1955, 10, 10), Telefono = "123-456-7800" },
            new Persona { Id = 11, Nombre = "Sofía", FechaNacimiento = new DateTime(1950, 11, 11), Telefono = "123-456-7801" },
            new Persona { Id = 12, Nombre = "Pablo", FechaNacimiento = new DateTime(1945, 12, 12), Telefono = "123-456-7802" },
            new Persona { Id = 13, Nombre = "Carmen", FechaNacimiento = new DateTime(1940, 1, 13), Telefono = "123-456-7803" },
            new Persona { Id = 14, Nombre = "José", FechaNacimiento = new DateTime(1935, 2, 14), Telefono = "123-456-7804" },
            new Persona { Id = 15, Nombre = "Rosa", FechaNacimiento = new DateTime(1930, 3, 15), Telefono = "123-456-7805" },
            new Persona { Id = 16, Nombre = "Javier", FechaNacimiento = new DateTime(1925, 4, 16), Telefono = "123-456-7806" },
            new Persona { Id = 17, Nombre = "Paula", FechaNacimiento = new DateTime(1920, 5, 17), Telefono = "123-456-7807" },
            new Persona { Id = 18, Nombre = "Miguel", FechaNacimiento = new DateTime(1915, 6, 18), Telefono = "123-456-7808" },
            new Persona { Id = 19, Nombre = "Cristina", FechaNacimiento = new DateTime(1910, 7, 19), Telefono = "123-456-7809" },
            new Persona { Id = 20, Nombre = "Roberto", FechaNacimiento = new DateTime(1905, 8, 20), Telefono = "123-456-7810" }
        
        };
       

            modelBuilder.Entity<Persona>().HasData(personas);
        }

        }

}

