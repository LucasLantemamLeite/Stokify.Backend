namespace Stokify.Domain.Abstracts.Base;

public abstract class Entity
{
    public Guid Id { get; protected set; }

    public Entity()
        => Id = Guid.NewGuid();

    public Entity(Guid id)
        => Id = id;
}