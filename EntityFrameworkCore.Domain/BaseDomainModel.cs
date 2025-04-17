namespace EntityFrameworkCore.Domain;

public abstract class BaseDomainModel
{
    public DateTime CreatedDate { get; set; } = new DateTime(2025, 04, 17);
}
