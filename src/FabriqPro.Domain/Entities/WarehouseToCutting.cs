using FabriqPro.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabriqPro.Domain.Entities;

public class WarehouseToCutting:Auditable
{
    public long Amount { get; set; }
    public long StockerId {  get; set; }
    public long ResourceId {  get; set; }
    public long WarehouseId { get;set; }
    public long CuttingMasterId {  get; set; }  
}
