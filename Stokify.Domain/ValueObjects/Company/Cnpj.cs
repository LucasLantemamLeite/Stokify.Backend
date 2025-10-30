namespace Stokify.Domain.ValueObjects.Company;

public sealed class Cnpj : IValueObject
{
    public string Value { get; } = null!;

    public Cnpj(string cnpj)
    {
        Value = cnpj;
    }

    private Cnpj() { }
}