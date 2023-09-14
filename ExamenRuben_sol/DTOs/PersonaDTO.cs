using System.ComponentModel.DataAnnotations;

namespace DTOs
{
    public class PersonaDTO
    {
        [Required(ErrorMessage = "El Nombre de usuario es obligatorio.")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "La fecha de nacimiento de usuario es obligatorio.")]
        public string FechaNacimiento { get; set; }

        public string? Telefono { get; set; }
    }
}