namespace Stokify.Domain.ValueObjects.Inventory;

public sealed class Quantity : IValueObject
{
    public decimal Value { get; }

    public Quantity(decimal quantity)
    {
        IsNumberException.ThrowIfNotIsNumber(quantity.ToString(), "decimal", "Inventário: quantidade atual deve conter apenas números e virgula.");
        Value = quantity;
    }
    private Quantity() { }
}