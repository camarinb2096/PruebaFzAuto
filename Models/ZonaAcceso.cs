using System.ComponentModel.DataAnnotations;

namespace AppAcceso.Models
{
    public class ZonaAcceso
    {
        [Key]
        public int IdZonaAcceso { get; set; }

        //[Required]
        [StringLength(50)]
        public string NombreZona { get; set; }
    }
}
