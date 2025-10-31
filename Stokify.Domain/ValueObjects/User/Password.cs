namespace Stokify.Domain.ValueObjects.User;

public sealed class Password : IValueObject
{
    public string Value { get; } = null!;

    public Password(string password)
    {
        MaxLenghtException.ThrowIfGreaterThan(password, 30, "Usuário: senha deve ser menor que 30 caracteres.");
        Value = password;
    }

    private Password() { }
}