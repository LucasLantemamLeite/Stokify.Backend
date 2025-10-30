namespace Stokify.Domain.ValueObjects.Common;

public sealed class UpdatedAt : IValueObject
{
    public DateTime Value { get; }

    public UpdatedAt(DateTime updated)
        => Value = updated;

    public UpdatedAt() => Value = DateTime.UtcNow;
}