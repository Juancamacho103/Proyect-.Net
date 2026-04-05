namespace InventarioApp.Factories;
using InventarioApp.Models;

public static class ProductFactory
{
    private static int _nextId = 1;

    public static Producto CrearProducto(string nombre, decimal precio, int cantidad, CategoriaProducto categoria = CategoriaProducto.Electronica)
    {
         if(string.IsNullOrWhiteSpace(nombre))
         {
             throw new ArgumentException("El nombre del producto no puede estar vacío.", nameof(nombre));
         }
         if(precio < 0)
         {
             throw new ArgumentOutOfRangeException(nameof(precio), "El precio no puede ser negativo.");
         }
         if(cantidad < 0)
         {
             throw new ArgumentOutOfRangeException(nameof(cantidad), "La cantidad no puede ser negativa.");
         }
         return new Producto
         {
             Id = _nextId++,
             Nombre = nombre,
             Precio = precio,
             Cantidad = cantidad,
             Categoria = categoria,
             FechaIngreso = DateTime.Now
         };
    }

    public static Producto CrearConStockInicial(string nombre, decimal precio, int cantidad)
    {
        if (cantidad < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(cantidad), "La cantidad no puede ser negativa.");
        }
        return CrearProducto(nombre, precio, cantidad);
    }
}