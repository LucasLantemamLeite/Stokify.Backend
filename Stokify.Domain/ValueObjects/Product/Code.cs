namespace Stokify.Domain.ValueObjects.Product;

public sealed class Code : IValueObject
{
    public int Value { get; }

    public Code(int code)
    {
        IsNumberException.ThrowIfNotIsNumber(code.ToString(), "int", "Produto: código deve conter apenas números.");
        Value = code;
    }

    private Code() { }
}