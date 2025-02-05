using FabriqPro.Domain.Commons;

namespace FabriqPro.Domain.Entities;

public class User : Auditable
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public DateOnly BirthDay { get; set; }

    public string PassportSeriya { get; set; }

    public long PassportNumber { get; set; }

    public string Password { get; set; }

    public string Phone { get; set; }

    public long WorkingPartId { get; set; }

    public WorkingPart WorkingPart { get; set; }
}
