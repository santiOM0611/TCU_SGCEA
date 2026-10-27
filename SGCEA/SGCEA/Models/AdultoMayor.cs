using System.ComponentModel.DataAnnotations;

namespace SGCEA.Models
{
    public class AdultoMayor
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El primer apellido es obligatorio")]
        [Display(Name = "Primer apellido")]
        public string PrimerApellido { get; set; }

        [Display(Name = "Segundo apellido")]
        public string SegundoApellido { get; set; }

        [Required(ErrorMessage = "La cédula es obligatoria")]
        [Display(Name = "Cédula")]
        public string Cedula { get; set; }

        [Required(ErrorMessage = "La fecha de nacimiento es obligatoria")]
        [Display(Name = "Fecha de nacimiento")]
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }

        [Display(Name = "Teléfono")]
        public string Telefono { get; set; }

        [Display(Name = "Dirección")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "El contacto de emergencia es obligatorio")]
        [Display(Name = "Contacto de emergencia")]
        public string ContactoEmergencia { get; set; }

        [Display(Name = "Teléfono de emergencia")]
        public string TelefonoEmergencia { get; set; }

        [Display(Name = "Estado")]
        public bool Activo { get; set; } = true;

        // Navegación
        public ICollection<Asistencia> Asistencias { get; set; }
        public ICollection<ParticipacionActividad> Participaciones { get; set; }
    }
}