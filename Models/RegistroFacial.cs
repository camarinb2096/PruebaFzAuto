using AppAcceso.Models;
public class RegistroFacial
{
    public int Id { get; set; }
    public byte[] DatosFacial { get; set; }
    public int UsuarioId { get; set; }
    public Usuario Usuario { get; set; }
}