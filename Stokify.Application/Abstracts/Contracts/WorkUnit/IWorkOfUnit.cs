namespace Stokify.Application.Abstracts.Contracts.WorkUnit;

public interface IWorkOfUnit : IDisposable
{
    Task<int> CommitAsync();
}