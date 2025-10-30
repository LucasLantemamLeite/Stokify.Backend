namespace Stokify.Domain.ValueObjects.Product;

public sealed class Density : IValueObject
{
    public decimal Value { get; }

    public Density(decimal density)
    {
        Value = density;
    }

    private Density() { }
}