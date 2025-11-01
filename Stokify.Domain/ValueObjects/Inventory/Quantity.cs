namespace Stokify.Domain.ValueObjects.Inventory;

public sealed class Quantity : IValueObject
{
    public decimal Value { get; }

    public Quantity(decimal quantity)
        => Value = quantity;

    private Quantity() { }
}