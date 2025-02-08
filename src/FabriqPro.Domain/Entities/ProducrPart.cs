using FabriqPro.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabriqPro.Domain.Entities;

public class ProducrPart:Auditable
{
    public string Name {  get; set; }
    public decimal Price { get; set; }
    public long ResourceId {  get; set; }
    public decimal CutterPrice {  get; set; }
    public decimal SewerPrice { get; set; }
    public string Description { get; set; }
}
