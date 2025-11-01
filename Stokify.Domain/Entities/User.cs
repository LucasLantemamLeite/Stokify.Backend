using Stokify.Domain.ValueObjects.User;

namespace Stokify.Domain.Entities;

public sealed class User : Entity<Guid>, IAggregateRoot
{
    public Name Name { get; private set; } = null!;
    public Phone Phone { get; private set; } = null!;
    public Email Email { get; private set; } = null!;
    public Password Password { get; private set; } = null!;
    public SystemRole SystemRole { get; private set; } = null!;
    public CreatedAt CreatedAt { get; private set; } = new();
    public UpdatedAt UpdatedAt { get; private set; } = new();
    public Active Active { get; private set; } = null!;
}