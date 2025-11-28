using Stokify.Domain.Abstractions.Markers;

namespace Stokify.Application.Shared.Contracts.Repositories;

public interface IRepository<TAggregate> where TAggregate : IAggregateRoot
{
    Task CreateAsync(TAggregate entity);
    Task DeleteAsync(TAggregate entity);
    Task UpdateAsync(TAggregate entity);
    Task<TAggregate?> GetByIdAsync(Guid id);
}