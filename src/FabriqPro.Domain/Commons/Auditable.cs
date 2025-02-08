namespace FabriqPro.Domain.Commons;

public abstract class Auditable
{
    public long Id { get; set; }

    public DateTime CreatedOnUtc { get; set; } = DateTime.UtcNow;

    public DateTime? UpdatedOnUtc { get; set; }

    public DateTime? DeletedOnUtc { get; set; }
    public long UpdateByUserId {  get; set; }

    public bool IsDeleted { get; set; }
}
