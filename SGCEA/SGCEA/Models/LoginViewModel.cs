using System.ComponentModel.DataAnnotations;

namespace SGCEA.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "El correo es obligatorio")]
        [EmailAddress(ErrorMessage = "Correo no válido")]
        [RegularExpression(@"^\S+$", ErrorMessage = "El correo no puede contener espacios")]
        [Display(Name = "Correo electrónico")]
        public string Email { get; set; }

        [Required(ErrorMessage = "La contraseña es obligatoria")]
        [DataType(DataType.Password)]
        [RegularExpression(@"^\S+$", ErrorMessage = "La contraseña no puede contener espacios")]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }
    }
}