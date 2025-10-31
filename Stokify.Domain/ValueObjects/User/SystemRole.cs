namespace Stokify.Domain.ValueObjects.User;

public sealed class SystemRole : IValueObject
{
    public ESystemRole Value { get; } = ESystemRole.User;

    public SystemRole(int role)
    {
        EnumException.ThrowIfNotDefined<ESystemRole>(role, "Usuário: nível de acesso inválido.");
        Value = (ESystemRole)role;
    }

    private SystemRole() { }
}