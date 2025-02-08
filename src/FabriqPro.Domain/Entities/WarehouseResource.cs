using FabriqPro.Domain.Commons;

namespace FabriqPro.Domain.Entities;

public class WarehouseResource : Auditable
{
    public long WarehouseId { get; set; }
    public long ResourceId { get; set; }
}
