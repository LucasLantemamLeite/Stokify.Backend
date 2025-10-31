namespace Stokify.Domain.ValueObjects.WareHouse;

public sealed class CurrentVolume : IValueObject
{
    public decimal? Value { get; } = null;

    public CurrentVolume(decimal current)
    {
        IsNumberException.ThrowIfNotIsNumber(current.ToString(), "decimal", "Armaźem: volume atual deve conter apenas números e virgula.");
        Value = current;
    }

    private CurrentVolume() { }
}