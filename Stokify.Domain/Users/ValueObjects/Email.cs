using Flunt.Notifications;
using Flunt.Validations;
using Stokify.Domain.Abstractions.Markers;

namespace Stokify.Domain.Users.ValueObjects;

public sealed class Email : Notifiable<Notification>, IValueObject
{
    public string Value { get; } = null!;

    public Email(string email)
    {
        AddNotifications(new Contract<string>()
            .Requires()
            .IsEmail(email, "Email.Value", "Usuário: Email inválido."));

        if (IsValid)
            Value = email.ToLower();
    }
}