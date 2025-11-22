namespace Stokify.Domain.ValueObjects.User;

public sealed class Password : Notifiable<Notification>, IValueObject
{
    public string Value { get; } = null!;

    public Password(string password)
    {
        AddNotifications(new Contract<string>()
            .Requires()
            .IsNotNullOrWhiteSpace(password, "Password.Value", "Usuário: senha é obrigatório."));

        if (IsValid)
            Value = password;
    }
}