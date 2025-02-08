using FabriqPro.Domain.Commons;
using System.Reflection.Emit;

namespace FabriqPro.Domain.Entities;

public class WarehouseOutOperation : Auditable
{
    public long Amount { get; set; }
    public long Price { get; set; }
    public long ResourceId { get; set; }
    public long UserId { get; set; }
    public long WarehouseId { get; set; }
    public OperandType OperationType { get; set; } 
}
