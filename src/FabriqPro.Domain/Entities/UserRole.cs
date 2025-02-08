using FabriqPro.Domain.Commons;

namespace FabriqPro.Domain.Entities;

public class UserRole : Auditable
{
    public User User { get; set; }
    public long UserId { get; set; }    
    public Role Role { get; set; }
    public long RoleId { get; set; }
}