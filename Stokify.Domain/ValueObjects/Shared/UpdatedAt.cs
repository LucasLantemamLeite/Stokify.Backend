namespace Stokify.Domain.ValueObjects.Shared;

public sealed class UpdatedAt : IValueObject
{
    public DateTime Value { get; }

    public UpdatedAt()
        => Value = DateTime.UtcNow;

    public UpdatedAt(DateTime created)
       => Value = created;
}