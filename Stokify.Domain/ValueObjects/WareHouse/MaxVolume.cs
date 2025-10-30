namespace Stokify.Domain.ValueObjects.WareHouse;

public sealed class MaxVolume : IValueObject
{
    public decimal Value { get; }

    public MaxVolume(decimal max) => Value = max;

    private MaxVolume() { }
}