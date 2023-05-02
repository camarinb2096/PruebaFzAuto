using System;

namespace AppAcceso.Models
{
    public class Registro
    {
        public int IdRegistro { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int IdUsuario { get; set; }
        public int IdZonaAcceso { get; set; }
        public int IdTipoRegistro { get; set; }
        public Usuario Usuario { get; set; }
        public ZonaAcceso ZonaAcceso { get; set; }
        public TipoRegistro TipoRegistro { get; set; }
    }
}
