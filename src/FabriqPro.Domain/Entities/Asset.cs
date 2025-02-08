using FabriqPro.Domain.Commons;

namespace FabriqPro.Domain.Entities;

public class Asset : Auditable
{
    public string Name { get; set; }
    public string Path {  get; set; }
}