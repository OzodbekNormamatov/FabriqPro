using FabriqPro.Domain.Commons;

namespace FabriqPro.Domain.Entities;

public class Warehouse : Auditable
{
    public string Name { get; set; }
    public string Description { get; set; }
}
