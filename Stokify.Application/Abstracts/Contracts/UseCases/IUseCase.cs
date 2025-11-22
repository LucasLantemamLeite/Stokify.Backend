using Stokify.Application.Abstracts.Markers;
using Stokify.Application.Results;

namespace Stokify.Application.Abstracts.Contracts.UseCases;

public interface IUseCase<TResult, TCommand> where TCommand : ICommand
{
    Task<Result<TResult>> ExecuteAsync(TCommand command);
}
