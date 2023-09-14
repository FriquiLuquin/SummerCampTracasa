using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Persona
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Nombre { get; set; }
        
        public DateTime FechaNacimiento { get; set; }
         [MaxLength(25)]
        public string? Telefono { get; set; }
    }
}