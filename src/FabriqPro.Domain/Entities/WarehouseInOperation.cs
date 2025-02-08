using FabriqPro.Domain.Commons;

namespace FabriqPro.Domain.Entities;

public class WarehouseInOperation : Auditable
{
    public float Amount { get; set; }
    public long ResourceId { get; set; }
    public long StockerId { get; set; }
    public long EmployeeId { get; set; }
    public long WarehouseId { get; set; } 
}
