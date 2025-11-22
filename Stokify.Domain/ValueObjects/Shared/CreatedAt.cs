namespace Stokify.Domain.ValueObjects.Shared;

public sealed class CreatedAt : IValueObject
{
    public DateTime Value { get; }

    public CreatedAt()
        => Value = DateTime.UtcNow;

    public CreatedAt(DateTime created)
       => Value = created;
}