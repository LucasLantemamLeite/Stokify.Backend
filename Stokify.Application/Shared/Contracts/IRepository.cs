using Stokify.Domain.Shared.Base;

namespace Stokify.Application.Shared.Contracts;

public interface IRepository<TEntity> where TEntity : Entity;