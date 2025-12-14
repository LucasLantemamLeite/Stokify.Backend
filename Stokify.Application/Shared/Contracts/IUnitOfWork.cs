namespace Stokify.Application.Shared.Contracts;

public interface IUnitOfWork
{
    Task<int> CommitAsync(CancellationToken cancellationToken = default);
}