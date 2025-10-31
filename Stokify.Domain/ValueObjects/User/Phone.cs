using Stokify.Domain.Validations.Exceptions.User;

namespace Stokify.Domain.ValueObjects.User;

public sealed class Phone : IValueObject
{
    public string Value { get; } = null!;

    public Phone(string phone)
    {
        PhoneException.ThrowIfInvalid(phone, "Usuário: formato do número de telefone inválido.");
        Value = phone;
    }

    private Phone() { }
}