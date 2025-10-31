using Stokify.Domain.Validations.Exceptions.User;

namespace Stokify.Domain.ValueObjects.User;

public sealed class Role : IValueObject
{
    public ERole Value { get; } = ERole.User;

    public Role(int role)
    {
        EnumException.ThrowIfNotDefined<ERole>(role, "Usuário: nível de acesso inválido.");
        Value = (ERole)role;
    }

    private Role() { }
}