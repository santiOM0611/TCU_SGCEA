using System.ComponentModel.DataAnnotations;

namespace SGCEA.Models
{
    public class Asistencia
    {
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha")]
        public DateTime Fecha { get; set; }

        [Display(Name = "Presente")]
        public bool Presente { get; set; }

        [Display(Name = "Observaciones")]
        public string Observaciones { get; set; }

        // Llave foránea
        public int AdultoMayorId { get; set; }
        public AdultoMayor AdultoMayor { get; set; }
    }
}