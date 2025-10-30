namespace Stokify.Domain.Abstracts.Entity;

public abstract class Entity
{
    protected Guid Id { get; set; }
    protected Entity() => Id = Guid.NewGuid();
    protected Entity(Guid id) => Id = id;
}