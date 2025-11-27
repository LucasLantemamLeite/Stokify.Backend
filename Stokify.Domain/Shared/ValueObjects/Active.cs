using Stokify.Domain.Abstractions.Markers;

namespace Stokify.Domain.Shared.ValueObjects;

public sealed class Active : IValueObject
{
    public bool Value { get; }

    public Active()
        => Value = true;

    public Active(bool active)
        => Value = active;
}