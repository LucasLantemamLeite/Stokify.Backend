using Stokify.Domain.ValueObjects.Organization;

namespace Stokify.Domain.Entities;

public sealed class OrganizationUsers : Entity<int>, IAggregate
{
    public Guid UserId { get; private set; }
    public Guid OrganizationId { get; private set; }
    public OrgRole OrgRole { get; private set; } = null!;
}