namespace Stokify.Domain.ValueObjects.Common;

public sealed class Name : IValueObject
{
    public string Value { get; } = null!;

    public Name(string name, string entityName)
    {
        NullOrEmptyException.ThrowIfIsNullOrEmpty(name, $"{entityName}: Nome é obrigatório.");
        Value = name;
    }

    private Name() { }
}