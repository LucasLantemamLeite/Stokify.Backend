namespace Stokify.Domain.ValueObjects.Organization;

public sealed class OrgRole : IValueObject
{
    public EOrgRole Value { get; } = EOrgRole.Member;

    public OrgRole(int role)
    {
        EnumException.ThrowIfNotDefined<EOrgRole>(role, "Organização: nível de acesso inválido.");
        Value = (EOrgRole)role;
    }

    private OrgRole() { }
}