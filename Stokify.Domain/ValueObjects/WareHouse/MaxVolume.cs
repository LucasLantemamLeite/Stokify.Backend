namespace Stokify.Domain.ValueObjects.WareHouse;

public sealed class MaxVolume : IValueObject
{
    public decimal Value { get; }

    public MaxVolume(decimal max)
    {
        IsNumberException.ThrowIfNotIsNumber(max.ToString(), "decimal", "Armaźem: volume máximo deve conter apenas números e virgula.");
        Value = max;
    }

    private MaxVolume() { }
}