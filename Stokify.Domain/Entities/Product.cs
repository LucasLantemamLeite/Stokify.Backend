using Stokify.Domain.ValueObjects.Product;

namespace Stokify.Domain.Entities;

public sealed class Product : Entity<Guid>, IAggregateRoot
{
    public Name Name { get; private set; } = null!;
    public Code Code { get; private set; } = null!;
    public Density Density { get; private set; } = null!;
    public Description? Description { get; private set; }
    public Guid OrganizationId { get; private set; }
    public Active Active { get; private set; } = null!;
}