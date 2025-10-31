namespace Stokify.Domain.ValueObjects.Product;

public sealed class Description : IValueObject
{
    public string? Value { get; } = null;

    public Description(string? description)
    {
        MaxLenghtException.ThrowIfGreaterThan(description, 100, "Produto: descrição deve ser menor que 100 caracteres.");
        Value = description;
    }

    private Description() { }
}