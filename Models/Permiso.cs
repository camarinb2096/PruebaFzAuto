using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppAcceso.Models
{
    public class Permiso
    {
        [Key]
        public int IdPermiso { get; set; }

        //[Required]
        [StringLength(50)]
        public string NombrePermiso { get; set; }

        [ForeignKey("NivelAcceso")]
        public int NivelAccesoId { get; set; }

        [ForeignKey("ZonaAcceso")]
        public int ZonaAccesoId { get; set; }

        public virtual NivelAcceso NivelAcceso { get; set; }

        public virtual ZonaAcceso ZonaAcceso { get; set; }
    }
}
