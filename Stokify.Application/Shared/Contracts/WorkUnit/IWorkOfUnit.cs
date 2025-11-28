namespace Stokify.Application.Shared.Contracts.WorkUnit;

public interface IWorkOfUnit : IDisposable
{
    Task<int> CommitAsync();
}