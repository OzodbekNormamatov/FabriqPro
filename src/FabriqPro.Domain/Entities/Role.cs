using FabriqPro.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabriqPro.Domain.Entities;

public class Role:Auditable
{
    public string Name {  get; set; }

}
