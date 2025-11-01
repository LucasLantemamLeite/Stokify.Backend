namespace Stokify.Test.Domain.ValueObjects;

[Trait("Category", "ProductTest")]
public sealed class ProductTest
{
    [Theory]
    [InlineData(005)]
    [InlineData(012315)]
    [InlineData(546)]
    public void Code_ValidIntergerValue_ShouldNotThrowException(int code)
    {
        var ex = Record.Exception(() => new Code(code));

        Assert.Null(ex);
    }

    [Theory]
    [InlineData(5.3)]
    [InlineData(1.5)]
    [InlineData(0.3)]
    public void Density_ValidDecimalValue_ShouldNotThrowException(decimal density)
    {
        var ex = Record.Exception(() => new Density(density));

        Assert.Null(ex);
    }

    [Theory]
    [InlineData("A mineral composed primarily of sodium chloride, commonly used for seasoning and preserving food.")]
    [InlineData("The edible seeds of the rice plant, a staple food for a large part of the world’s population.")]
    [InlineData("A powder made by grinding grains, typically wheat, used for baking and cooking.")]
    [InlineData("")]
    [InlineData("  ")]
    [InlineData(null)]
    public void Description_ValidStringValue_ShouldNotThrowMaxLenghtException(string? description)
    {
        var ex = Record.Exception(() => new Description(description));

        Assert.Null(ex);
    }

    [Theory]
    [InlineData("Sugar is a sweet crystalline substance derived from sugarcane or sugar beet, commonly used to sweeten foods and beverages in cooking and baking.")]
    [InlineData("Salt is a mineral composed primarily of sodium chloride, widely used to season and preserve various types of food across the world.")]
    [InlineData("Rice is the edible seed of the rice plant, serving as a staple food for millions globally and used in a wide variety of dishes.")]
    public void Description_DecimalValue_ShouldNotThrowException(string? description)
    {
        var ex = Assert.Throws<MaxLenghtException>(() => new Description(description));

        Assert.NotNull(ex);
        Assert.Equal("Produto: descrição deve ser menor que 100 caracteres.", ex.Message);
    }
}