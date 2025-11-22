namespace Stokify.Domain.ValueObjects.User;

public sealed class Email : Notifiable<Notification>, IValueObject
{
    public required string Value { get; init; }

    public Email(string email)
    {
        AddNotifications(new Contract<string>()
            .Requires()
            .IsEmail(email, "Email.Value", "Usuário: email inválido."));

        if (IsValid)
            Value = email;
    }
}