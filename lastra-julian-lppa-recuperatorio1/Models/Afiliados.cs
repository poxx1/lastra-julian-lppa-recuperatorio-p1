using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Afiliados : IdentityBase
    {
        [Required(ErrorMessage = "Campo requerido")]
        [MaxLength(25)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [MaxLength(25)]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [MaxLength(35)]
        [EmailAddress(ErrorMessage = "El email es incorrecto")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [DisplayName("Teléfono")]
        public long Telefono { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        public long Cuit { get; set; }

        [NotMapped]
        public string NombreCompleto
        {
            get
            {
                return Nombre + " " + Apellido;
            }
        }
    }
}