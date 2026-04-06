namespace InventarioApp.Repositories;

using InventarioApp.Models;

public interface IProductRespositrory
{
    IEnumerable<Producto> GetAll();
    Producto? GetById(int id);
    void Add(Producto producto);
    void Update(Producto producto);
    void Delete(int id);
    int cantidadTotal { get; }
}