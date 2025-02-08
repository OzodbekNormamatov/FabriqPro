using FabriqPro.Domain.Entities;

namespace FabriqPro.Service.Services.WarehouseInOperationsService;

public interface IWarehouseInOperationService
{
    public ValueTask<WarehouseInOperation> CreateAsync(WarehouseInOperation warehouseInOperations);
    public ValueTask<WarehouseInOperation> UpdateAsync(WarehouseInOperation warehouseInOperation, long id);
    public ValueTask<bool> DeleteAsync(long id);
    public ValueTask<WarehouseInOperation> GetByIdAsync(long id);
    public ValueTask<IEnumerable<WarehouseInOperation>> GetAllAsync();
}
