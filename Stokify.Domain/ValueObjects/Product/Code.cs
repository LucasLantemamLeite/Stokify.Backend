namespace Stokify.Domain.ValueObjects.Product;

public sealed class Code : IValueObject
{
    public int Value { get; }

    public Code(int code)
        => Value = code;

    private Code() { }
}