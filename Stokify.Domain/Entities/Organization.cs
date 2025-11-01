using System.Collections.ObjectModel;

namespace Stokify.Domain.Entities;

public sealed class Organization : Entity<Guid>, IAggregateRoot
{
    private readonly List<OrganizationUsers> _organizationUsers = [];

    public Name Name { get; private set; } = null!;
    public CreatedAt CreatedAt { get; private set; } = new();
    public UpdatedAt UpdatedAt { get; private set; } = new();
    public Active Active { get; private set; } = null!;
    public Guid OwnerId { get; private set; }
    public ReadOnlyCollection<OrganizationUsers> OrganizationUsers => _organizationUsers.AsReadOnly();
}