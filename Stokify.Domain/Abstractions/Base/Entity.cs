namespace Stokify.Domain.Abstractions.Base;

public abstract class Entity
{
    public Guid Id { get; protected set; }

    public Entity(Guid id)
        => Id = id;

    public Entity()
        => Id = Guid.NewGuid();
}