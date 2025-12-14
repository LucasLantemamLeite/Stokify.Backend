using Stokify.Domain.Shared.Base;
using Stokify.Domain.Users.Enums;

namespace Stokify.Domain.Users;

public sealed class User : Entity
{
    public string Name { get; private set; } = null!;
    public string Email { get; private set; } = null!;
    public string Phone { get; private set; } = null!;
    public string Password { get; private set; } = null!;
    public ESystemRole SystemRole { get; private set; } = ESystemRole.Member;
    public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; private set; } = DateTime.UtcNow;
    public bool Active { get; private set; } = true;

    public User(string name, string email, string phone, string password, int role)
    {
        Name = name;
        Email = email;
        Phone = phone;
        Password = password;
        SystemRole = (ESystemRole)role;
    }

    public User(Guid id, string name, string email, string phone, string password, int role, DateTime created, DateTime updated, bool active) : base(id)
    {
        Name = name;
        Email = email;
        Phone = phone;
        Password = password;
        SystemRole = (ESystemRole)role;
        CreatedAt = created;
        UpdatedAt = updated;
        Active = active;
    }

    private User() { }
}