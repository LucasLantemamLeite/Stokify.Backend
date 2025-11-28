using Stokify.Application.Shared.Contracts.WorkUnit;
using Stokify.Infrastructure.Data.Context;

namespace Stokify.Infrastructure.WorkUnit;

public sealed class WorkOfUnit : IWorkOfUnit
{
    private readonly AppDbContext _context;
    public WorkOfUnit(AppDbContext context)
        => _context = context;

    public async Task<int> CommitAsync()
        => await _context.SaveChangesAsync();

    public void Dispose()
        => _context.Dispose();
}