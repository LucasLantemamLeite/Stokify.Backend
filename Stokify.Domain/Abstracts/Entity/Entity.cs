namespace Stokify.Domain.Abstracts.Entity;

public abstract class Entity<T>
{
    public T? Id { get; protected set; }
    protected Entity()
    {
        if (typeof(T) == typeof(Guid))
            Id = (T)(object)Guid.NewGuid();

        else if (typeof(T) != typeof(int))
            throw new ArgumentException($"O tipo {typeof(T).Name} não é suportado como identificador de entidade. Use Guid para Aggregate Roots ou int para entidades auxiliares.");
    }

    protected Entity(T id) => Id = id;
}