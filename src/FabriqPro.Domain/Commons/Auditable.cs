namespace FabriqPro.Domain.Commons;

public abstract class Auditable
{
    public long Id { get; set; }

    public DateTime CreatedOnUtc { get; set; }

    public DateTime? UpdatedOnUtc { get; set; }

    public DateTime? DeletedOnUtc { get; set; }

    public bool IsDeleted { get; set; }
}
