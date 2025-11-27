using System.Text.RegularExpressions;
using Flunt.Notifications;
using Flunt.Validations;
using Stokify.Domain.Abstractions.Markers;

namespace Stokify.Domain.Users.ValueObjects;

public sealed partial class Phone : Notifiable<Notification>, IValueObject
{
    public string Value { get; } = null!;

    [GeneratedRegex(@"^\+?[1-9]\d{7,14}$")]
    private partial Regex PhoneRegex();

    public Phone(string phone)
    {
        AddNotifications(new Contract<string>()
            .Requires()
            .IsTrue(PhoneRegex().IsMatch(phone), "Phone.Value", "Usuário: número de telefone inválido."));

        if (IsValid)
            Value = phone;
    }
}