namespace Stokify.Domain.ValueObjects.Inventory;

public sealed class CurrentVolume : IValueObject
{
    public decimal? Value { get; } = null;

    public CurrentVolume(decimal current)
        => Value = current;

    private CurrentVolume() { }
}