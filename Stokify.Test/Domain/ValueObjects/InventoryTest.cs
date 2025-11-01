namespace Stokify.Test.Domain.ValueObjects;

[Trait("Category", "InventoryTest")]
public sealed class InventoryTest
{
    [Theory]
    [InlineData(15.5)]
    [InlineData(31.23)]
    [InlineData(5.97)]
    public void CurrentVolume_ValidDecimalValue_ShouldNotThrowrException(decimal volume)
    {
        var ex = Record.Exception(() => new CurrentVolume(volume));

        Assert.Null(ex);
    }

    [Theory]
    [InlineData(10.12)]
    [InlineData(697.556)]
    [InlineData(5456.13)]
    public void Quantity_ValidDecimalValue_ShouldNotThrowException(decimal volume)
    {
        var ex = Record.Exception(() => new Quantity(volume));

        Assert.Null(ex);
    }
}