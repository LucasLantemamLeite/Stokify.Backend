namespace Stokify.Domain.ValueObjects.Common;

public sealed class Active : IValueObject
{
    public bool Value { get; } = true;

    public Active(bool active)
        => Value = active;

    private Active() { }
}