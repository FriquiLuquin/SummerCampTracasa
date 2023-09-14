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

    }

}

