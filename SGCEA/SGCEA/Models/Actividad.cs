using System.ComponentModel.DataAnnotations;

namespace SGCEA.Models
{
    public class Actividad
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha")]
        public DateTime Fecha { get; set; }

        [Display(Name = "Hora de inicio")]
        [DataType(DataType.Time)]
        public TimeSpan HoraInicio { get; set; }

        [Display(Name = "Hora de fin")]
        [DataType(DataType.Time)]
        public TimeSpan HoraFin { get; set; }

        [Display(Name = "Responsable")]
        public string Responsable { get; set; }

        // Navegación
        public ICollection<ParticipacionActividad> Participaciones { get; set; }
    }
}