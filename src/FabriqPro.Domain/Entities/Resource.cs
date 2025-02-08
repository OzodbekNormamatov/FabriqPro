using FabriqPro.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabriqPro.Domain.Entities;

public class Resource:Auditable
{
    public string Unit { get; set; }
    public string Code {  get; set; }
    public string Name { get; set; }
    public string Color {  get; set; }
    public decimal Total {get; set; }
    public string Description { get; set; }
}
