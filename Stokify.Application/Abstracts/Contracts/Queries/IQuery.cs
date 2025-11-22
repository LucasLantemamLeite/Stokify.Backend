using Stokify.Domain.Abstracts.Base;

namespace Stokify.Application.Abstracts.Contracts.Queries;

public interface IQuery<TEntity> where TEntity : Entity
{
    Task<TEntity?> GetByIdAsync(Guid id);
}