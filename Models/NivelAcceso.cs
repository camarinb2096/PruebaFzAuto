using System.ComponentModel.DataAnnotations;

namespace AppAcceso.Models
{
    public class NivelAcceso
    {
        [Key]
        public int IdNivelAcceso { get; set; }

        //[Required]
        [StringLength(50)]
        public string NombreNivel { get; set; }
    }
}