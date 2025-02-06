using FabriqPro.Domain.Commons;

namespace FabriqPro.Domain.Entities;

public class PaidSalary : Auditable
{
    public long UserId { get; set; }

    public decimal Amount { get; set; }
}
