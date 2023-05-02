using AppAcceso.Models;

public class Huella
{
    public int Id { get; set; }
    public byte[] DatosHuella { get; set; }
    public int UsuarioId { get; set; }
    public Usuario Usuario { get; set; }
}

