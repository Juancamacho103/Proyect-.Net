namespace InventarioApp.Models;

public class Producto
{
    private string _nombre = "";
    private decimal _precio;
    private int _cantidad;
    public int Id { get; set; }
    public string Nombre 
    { 
        get => _nombre; 
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("El nombre del producto no puede estar vacío.", nameof(Nombre));
            }
            _nombre = value.Trim();
        }
    }
    public decimal Precio 
    { 
        get => _precio; 
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(Precio), "El precio no puede ser negativo.");
            }
            _precio = value;
        }
    }
    public int Cantidad 
    { 
        get => _cantidad; 
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(Cantidad), "La cantidad no puede ser negativa.");
            }
            _cantidad = value;
        }
    }
    public CategoriaProducto Categoria { get; set; }
    public CategoriaProducto CategoriaProducto { get; set; }
    public DateTime FechaIngreso { get; set; } = DateTime.Now;
    public decimal ValorTotal => Cantidad * Precio;
}