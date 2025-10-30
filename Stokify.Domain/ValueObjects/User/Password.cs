namespace Stokify.Domain.ValueObjects.User;

public sealed class Password : IValueObject
{
    public string Value { get; } = null!;

    public Password(string password) => Value = password;

    private Password() { }
}