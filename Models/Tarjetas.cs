using AppAcceso.Models;

public class Tarjeta
{
    public int Id { get; set; }
    public string NumeroTarjeta { get; set; }
    public DateTime FechaExpiracion { get; set; }
    public int UsuarioId { get; set; }
    public Usuario Usuario { get; set; }
}