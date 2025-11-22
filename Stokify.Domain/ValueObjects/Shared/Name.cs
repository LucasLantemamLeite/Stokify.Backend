namespace Stokify.Domain.ValueObjects.Shared;

public sealed class Name : Notifiable<Notification>, IValueObject
{
    public string Value { get; } = null!;

    public Name(string name, string entityName)
    {
        AddNotifications(new Contract<string>()
            .Requires()
            .IsNotNullOrWhiteSpace(name, "Name.Value", $"{entityName}: Nome é obrigatório."));

        if (IsValid)
            Value = name;
    }

    private Name() { }
}