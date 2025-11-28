using System.Collections.ObjectModel;
using Flunt.Notifications;
using Stokify.Domain.Abstractions.Base;
using Stokify.Domain.Abstractions.Contracts;
using Stokify.Domain.Abstractions.Markers;
using Stokify.Domain.Shared.ValueObjects;
using Stokify.Domain.Users.ValueObjects;

namespace Stokify.Domain.Users;

public sealed class User : Entity, IAggregateRoot, IValidatable
{
    public Name Name { get; private set; } = null!;
    public Email Email { get; private set; } = null!;
    public Phone Phone { get; private set; } = null!;
    public Password Password { get; private set; } = null!;
    public Access Access { get; private set; } = new();
    public CreatedAt CreatedAt { get; private set; } = new();
    public UpdatedAt UpdatedAt { get; private set; } = new();
    public Active Active { get; private set; } = new();

    // Validate
    private readonly List<Notification> _notification = [];
    public ReadOnlyCollection<Notification> Notification => _notification.AsReadOnly();
    public bool Validate()
    {
        _notification.Clear();

        _notification.AddRange(Name.Notifications);
        _notification.AddRange(Email.Notifications);
        _notification.AddRange(Phone.Notifications);
        _notification.AddRange(Access.Notifications);

        return _notification.Count == 0;
    }

    public User(string name, string email, string phone, string password, int access)
    {
        Name = new(name, "Usuário");
        Email = new(email);
        Phone = new(phone);
        Password = new(password);
        Access = new(access);
    }

    private User() { }
}