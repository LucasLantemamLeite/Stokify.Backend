namespace Stokify.Domain.ValueObjects.User;

public sealed class Email : IValueObject
{
    public string Value { get; } = null!;

    public Email(string email) { Value = email; }

    private Email() { }
}