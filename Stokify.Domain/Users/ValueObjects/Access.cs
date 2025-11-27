using Flunt.Notifications;
using Flunt.Validations;
using Stokify.Domain.Abstractions.Markers;
using Stokify.Domain.Enums;

namespace Stokify.Domain.Users.ValueObjects;

public sealed class Access : Notifiable<Notification>, IValueObject
{
    public EAccess Value { get; }

    public Access(int access)
    {
        AddNotifications(new Contract<EAccess>()
            .Requires()
            .IsTrue(Enum.IsDefined(typeof(EAccess), access), "Access.Value", "Usuário: nível de acesso inválido."));

        if (IsValid)
            Value = (EAccess)access;
    }

    public Access()
        => Value = EAccess.Member;
}