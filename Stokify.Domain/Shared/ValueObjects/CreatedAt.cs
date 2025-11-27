using Stokify.Domain.Abstractions.Markers;

namespace Stokify.Domain.Shared.ValueObjects;

public sealed class CreatedAt : IValueObject
{
    public DateTime Value { get; }

    public CreatedAt()
        => Value = DateTime.UtcNow;

    public CreatedAt(DateTime created)
        => Value = created;
}