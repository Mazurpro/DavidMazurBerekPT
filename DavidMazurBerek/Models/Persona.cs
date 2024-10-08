using System.ComponentModel.DataAnnotations;

namespace DavidMazurBerek.Models
{
    public class Persona
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; } = string.Empty;
        [Required(ErrorMessage = "Los apellidos son obligatorios")]
        public string Apellidos { get; set; } = string.Empty;
        [Required(ErrorMessage = "El DNI es obligatorio")]
        public int DNI { get; set; }
        [Required(ErrorMessage = "El correo es obligatorio")]
        public string Email { get; set; } = string.Empty;
        [Required(ErrorMessage = "El telefono es obligatorio")]
        public string Telefono { get; set; } = string.Empty;
        [Required(ErrorMessage ="La direccion 1 es obligatoria")]
        public string Direccion { get; set; } = string.Empty;
        public string Direccion2 { get; set; } = string.Empty;
    }
}
