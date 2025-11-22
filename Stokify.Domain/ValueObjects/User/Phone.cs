using System.Text.RegularExpressions;

namespace Stokify.Domain.ValueObjects.User;

public sealed partial class Phone : Notifiable<Notification>, IValueObject
{
    public required string Value { get; init; }

    [GeneratedRegex(@"^\\+[1-9]{1}[0-9]{1,14}$")]
    private partial Regex PhoneRegex();

    public Phone(string phone)
    {
        AddNotifications(new Contract<string>()
            .Requires()
            .IsTrue(PhoneRegex().IsMatch(phone), phone, "Usuário: número de telefone inválido."));

        if (IsValid)
            Value = phone;
    }
}