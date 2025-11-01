namespace Stokify.Test.Domain.ValueObjects;

[Trait("Category", "CommonTest")]
public sealed class CommonTest
{
    [Theory]
    [InlineData("NameTest")]
    [InlineData("Name_Test")]
    [InlineData("Name Test")]
    public void Name_ValidStringValue_ShouldNotThrowNullOrEmptyException(string name)
    {
        var ex = Record.Exception(() => new Name(name, "Test"));

        Assert.Null(ex);
    }

    [Theory]
    [InlineData("")]
    [InlineData("  ")]
    [InlineData(null)]
    public void Name_EmptyOrNullStringValue_ShouldThrowNullOrEmptyException(string name)
    {
        var ex = Assert.Throws<NullOrEmptyException>(() => new Name(name, "Test"));

        Assert.NotNull(ex);
        Assert.Equal("Test: Nome é obrigatório.", ex.Message);
    }

    [Theory]
    [InlineData(2025, 9, 23)]
    [InlineData(2024, 5, 15)]
    [InlineData(2025, 1, 02)]
    public void CreatedAt_ValidDateValue_ShouldNotThrowException(int year, int month, int day)
    {
        var date = new DateTime(year, month, day);

        var ex = Record.Exception(() => new CreatedAt(date));

        Assert.Null(ex);
    }

    [Theory]
    [InlineData(2025, 9, 23)]
    [InlineData(2024, 5, 15)]
    [InlineData(2025, 1, 02)]
    public void UpdatedAt_ValidDateValue_ShouldNotThrowException(int year, int month, int day)
    {
        var date = new DateTime(year, month, day);

        var ex = Record.Exception(() => new UpdatedAt(date));

        Assert.Null(ex);
    }

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public void Active_ValidBooleanValue_ShouldNotThrowException(bool active)
    {
        var ex = Record.Exception(() => new Active(active));

        Assert.Null(ex);
    }
}