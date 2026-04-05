namespace InventarioApp.Models;

public record Proveedor
{
    public int Id { get; init; }
    public string Nombre { get; init; } = "";
    public string Contacto { get; init; } = "";
    public string Telefono { get; init; } = "";
    public string Email { get; init; } = "";
    public string Direccion { get; init; } = "";
}