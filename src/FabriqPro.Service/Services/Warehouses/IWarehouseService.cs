using FabriqPro.Domain.Entities;

namespace FabriqPro.Service.Services.Warehouses;

public interface IWarehouseService
{
    public ValueTask<Warehouse> CreateAsync(Warehouse warehouse);
    public ValueTask<Warehouse> UpdateAsync(long id, Warehouse warehouse);
    public ValueTask<bool> DeleteAsync(long id);
    public ValueTask<Warehouse> GetByIdAsync(long id);
    public ValueTask<IEnumerable<Warehouse>> GetAllAsync(long id);
}
 