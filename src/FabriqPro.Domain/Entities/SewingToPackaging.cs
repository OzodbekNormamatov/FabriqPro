using FabriqPro.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabriqPro.Domain.Entities;

public class SewingToPackaging:Auditable
{
    public long Count { get; set; }
    public long ProductId {  get; set; }
    public long SewingMasterId {  get; set; }
    public long PackagingMasterId {  get; set; }

}
