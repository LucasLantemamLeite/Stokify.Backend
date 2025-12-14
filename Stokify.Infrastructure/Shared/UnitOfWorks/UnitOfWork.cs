using Stokify.Application.Shared.Contracts;
using Stokify.Infrastructure.Data.Context;

namespace Stokify.Infrastructure.Shared.UnitOfWorks;

public sealed class UnitOfWork(AppDbContext context) : IUnitOfWork
{
    public async Task<int> CommitAsync(CancellationToken cancellationToken = default)
        => await context.SaveChangesAsync(cancellationToken);
}