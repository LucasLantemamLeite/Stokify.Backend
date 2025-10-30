namespace Stokify.Domain.ValueObjects.User;

public sealed class Phone : IValueObject
{
    public string Value { get; } = null!;

    public Phone(string phone) => Value = phone;

    private Phone() { }
}