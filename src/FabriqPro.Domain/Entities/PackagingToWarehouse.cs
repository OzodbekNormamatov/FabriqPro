using FabriqPro.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabriqPro.Domain.Entities;

public class PackagingToWarehouse:Auditable
{
    public long Count { get; set; }
    public long StokerId {  get; set; }
    public long ProductId {  get; set; }
    public long WarehouseId {  get; set; }
    public long PackagingMasterId {  get; set; }
}
