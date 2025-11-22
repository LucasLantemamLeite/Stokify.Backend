using Stokify.Domain.Enums;

namespace Stokify.Domain.ValueObjects.User;

public sealed class Access : Notifiable<Notification>, IValueObject
{
    public EAccess Value { get; } = EAccess.Member;

    public Access(sbyte access)
    {
        AddNotifications(new Contract<EAccess>()
            .Requires()
            .IsTrue(Enum.IsDefined(typeof(EAccess), access), "Access.Value", "Usuário: nível de acesso inválido."));

        if (IsValid)
            Value = (EAccess)access;
    }

    private Access() { }
}