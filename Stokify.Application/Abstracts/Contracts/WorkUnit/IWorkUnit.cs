namespace Stokify.Application.Abstracts.Contracts.WorkUnit;

public interface IWorkUnit : IDisposable
{
    Task<int> CommitAsync();
}