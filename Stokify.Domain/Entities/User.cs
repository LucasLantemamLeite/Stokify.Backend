using Stokify.Domain.Abstracts.Contracts;
using Stokify.Domain.ValueObjects.Shared;
using Stokify.Domain.ValueObjects.User;

namespace Stokify.Domain.Entities;

public sealed class User : Entity, IAggregateRoot, IValidatable
{
    public Name Name { get; private set; } = null!;
    public Email Email { get; private set; } = null!;
    public Phone Phone { get; private set; } = null!;
    public Password Password { get; private set; } = null!;
    public Access Access { get; private set; } = null!;
    public CreatedAt CreatedAt { get; private set; } = new();
    public UpdatedAt UpdatedAt { get; private set; } = new();
    public Active Active { get; private set; } = new();

    private readonly List<Notification> _notification = [];
    public bool IsValid { get => _notification.Count == 0; }
    public IReadOnlyCollection<Notification> Notifications { get => _notification.AsReadOnly(); }

    public bool Validate()
    {
        _notification.AddRange(Name.Notifications);
        _notification.AddRange(Email.Notifications);
        _notification.AddRange(Phone.Notifications);
        _notification.AddRange(Password.Notifications);
        _notification.AddRange(Access.Notifications);

        return IsValid;
    }

    public User(string name, string email, string phone, string password, sbyte access)
    {
        Name = new(name, "Usuário");
        Email = new(email);
        Phone = new(phone);
        Password = new(password);
        Access = new(access);
    }

    public User(Guid id, string name, string email, string phone, string password, sbyte access, DateTime created, DateTime updated, bool active) : base(id)
    {
        Name = new(name, "Usuário");
        Email = new(email);
        Phone = new(phone);
        Password = new(password);
        Access = new(access);
        CreatedAt = new(created);
        UpdatedAt = new(updated);
        Active = new(active);
    }

    private User() { }
}