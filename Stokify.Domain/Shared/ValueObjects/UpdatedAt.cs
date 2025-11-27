using Stokify.Domain.Abstractions.Markers;

namespace Stokify.Domain.Shared.ValueObjects;

public sealed class UpdatedAt : IValueObject
{
    public DateTime Value { get; }

    public UpdatedAt()
        => Value = DateTime.UtcNow;

    public UpdatedAt(DateTime created)
        => Value = created;
}