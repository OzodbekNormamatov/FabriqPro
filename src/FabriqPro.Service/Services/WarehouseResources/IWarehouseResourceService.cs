using Fab;
using FabriqPro.Domain.Entities;

namespace FabriqPro.Service.Services.WarehouseResources;

public interface IWarehouseResourceService
{
    public ValueTask<WarehouseResource> CreateAsync(WarehouseResource warehouseResource);
    public ValueTask<WarehouseResource> UpdateAsync(WarehouseResource warehouseResource, long id);
    public ValueTask<bool> DeleteAsync(long id);
    public ValueTask<WarehouseResource> GetByIdAsync(long id);
    public ValueTask<IEnumerable<WarehouseResource>> GetAllAsync();
}
