using Stokify.Domain.ValueObjects.Organization;

namespace Stokify.Test.Domain.ValueObjects;

[Trait("Category", "OrganizationTest")]
public sealed class OrganizationTest
{
    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(3)]
    [InlineData(4)]
    [InlineData(5)]
    public void OrgRole_ValidIntergerValue_ShouldNotThrowEnumException(int role)
    {
        var ex = Record.Exception(() => new OrgRole(role));

        Assert.Null(ex);
    }

    [Theory]
    [InlineData(6)]
    [InlineData(-1)]
    [InlineData(999)]
    public void OrgRole_InvalidIntergerValue_ShouldThrowEnumException(int role)
    {
        var ex = Assert.Throws<EnumException>(() => new OrgRole(role));

        Assert.NotNull(ex);
        Assert.Equal("Organização: nível de acesso inválido.", ex.Message);
    }
}