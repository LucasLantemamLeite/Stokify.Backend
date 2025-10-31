namespace Stokify.Domain.ValueObjects.Product;

public sealed class Density : IValueObject
{
    public decimal Value { get; }

    public Density(decimal density)
    {
        IsNumberException.ThrowIfNotIsNumber(density.ToString(), "decimal", "Produto: densidade deve conter apenas números e virgula.");
        Value = density;
    }

    private Density() { }
}