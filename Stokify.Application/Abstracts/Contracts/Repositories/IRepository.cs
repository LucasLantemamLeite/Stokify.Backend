using Stokify.Domain.Abstracts.Markers;

namespace Stokify.Application.Abstracts.Contracts.Repositories;

public interface IRepository<TAggregate> where TAggregate : IAggregateRoot
{
    Task CreateAsync(TAggregate entity);
    Task DeleteAsync(TAggregate entity);
    Task UpdateAsync(TAggregate entity);
}