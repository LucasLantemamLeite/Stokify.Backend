namespace Stokify.Domain.ValueObjects.Product;

public sealed class Description : IValueObject
{
    public string? Value { get; } = null;

    public Description(string? description)
        => Value = description;

    private Description() { }
}