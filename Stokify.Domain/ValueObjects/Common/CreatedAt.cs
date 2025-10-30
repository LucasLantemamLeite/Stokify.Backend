namespace Stokify.Domain.ValueObjects.Common;

public sealed class CreatedAt : IValueObject
{
    public DateTime Value { get; }

    public CreatedAt(DateTime created)
        => Value = created;

    public CreatedAt() => Value = DateTime.UtcNow;
}