using Stokify.Domain.ValueObjects.Inventory;

namespace Stokify.Domain.Entities;

public sealed class Inventory : Entity<int>, IAggregate
{
    public Guid WareHouseId { get; private set; }
    public Guid? ProductId { get; private set; }
    public Quantity? Quantity { get; private set; } = new(0);
    public CurrentVolume? CurrentVolume { get; private set; } = new(0);
    public Guid OrganizationId { get; private set; }

    public Inventory(Guid wareHouseId, Product? product, decimal? quantity, Guid organizationId)
    {
        WareHouseId = wareHouseId;
        ProductId = product?.Id;
        Quantity = new(quantity ?? 0);
        OrganizationId = organizationId;

        CurrentVolume = product != null
        ? new(product.Density.Value * quantity ?? 0)
        : new(0);
    }

    private Inventory() { }
}