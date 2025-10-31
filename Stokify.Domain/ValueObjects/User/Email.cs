using Stokify.Domain.Validations.Exceptions.User;

namespace Stokify.Domain.ValueObjects.User;

public sealed class Email : IValueObject
{
    public string Value { get; } = null!;

    public Email(string email)
    {
        EmailException.ThrowIfInvalid(email, "Usuário: formato do e-mail inválido.");
        Value = email;
    }

    private Email() { }
}