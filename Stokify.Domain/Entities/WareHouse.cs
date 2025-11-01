using System.Collections.ObjectModel;
using Stokify.Domain.ValueObjects.WareHouse;

namespace Stokify.Domain.Entities;

public sealed class WareHouse : Entity<Guid>, IAggregateRoot
{
    private readonly List<Inventory> _inventories = [];

    public Name Name { get; private set; } = null!;
    public MaxVolume MaxVolume { get; private set; } = null!;
    public Active Active { get; private set; } = null!;
    public Guid OrganizationId { get; private set; }
    public ReadOnlyCollection<Inventory> Inventories => _inventories.AsReadOnly();

    public void AddInventory(Product? product = null, decimal? quantity = null)
    {
        var inventory = new Inventory(Id, product, quantity, OrganizationId);

        _inventories.Add(inventory);
    }

    public void DeleteItemInventory(int id)
    {
        var item = _inventories.FirstOrDefault(x => x.Id == id);

        if (item is null)
            return;

        _inventories.Remove(item);
    }

    public void UpdateItemInventory(int id, Product? product = null, decimal? quantity = null)
    {
        var itemIndex = _inventories.FindIndex(x => x.Id == id);

        if (itemIndex is -1)
            return;

        var inventory = new Inventory(Id, product, quantity, OrganizationId);

        _inventories[itemIndex] = inventory;
    }

    public WareHouse(string name, decimal maxVolume, bool active, Guid organizationId)
    {
        Name = new(name, "Armazém");
        MaxVolume = new(maxVolume);
        Active = new(active);
        OrganizationId = organizationId;
    }

    public WareHouse(Guid id, string name, decimal maxVolume, bool active, Guid organizationId) : base(id)
    {
        Name = new(name, "Armazém");
        MaxVolume = new(maxVolume);
        Active = new(active);
        OrganizationId = organizationId;
    }

    private WareHouse() { }
}