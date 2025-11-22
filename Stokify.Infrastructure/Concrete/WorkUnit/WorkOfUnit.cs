using Stokify.Application.Abstracts.Contracts.WorkUnit;
using Stokify.Infrastructure.Data.Context;

namespace Stokify.Infrastructure.Concrete.WorkUnit;

public sealed class WorkOfUnit(AppDbContext context) : IWorkOfUnit
{
    public async Task<int> CommitAsync()
        => await context.SaveChangesAsync();

    public void Dispose()
        => context.Dispose();
}