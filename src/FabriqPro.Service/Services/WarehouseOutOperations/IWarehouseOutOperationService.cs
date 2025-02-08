using FabriqPro.Domain.Entities;

namespace FabriqPro.Service.Services.WarehouseOutOperations;

public interface IWarehouseOutOperationService
{
    public ValueTask<WarehouseOutOperation> CreateAsync(WarehouseOutOperation warehouseInOperations);
    public ValueTask<WarehouseInOperation> UpdateAsync(WarehouseOutOperation warehouseInOperation, long id);
    public ValueTask<bool> DeleteAsync(long id);
    public ValueTask<WarehouseOutOperation> GetByIdAsync(long id);
    public ValueTask<IEnumerable<WarehouseOutOperation>> GetAllAsync();
}
