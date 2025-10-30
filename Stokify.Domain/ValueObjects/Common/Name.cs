namespace Stokify.Domain.ValueObjects.Common;

public sealed class Name : IValueObject
{
    public string Value { get; } = null!;

    public Name(string name)
    {
        Value = name;
    }

    private Name() { }
}