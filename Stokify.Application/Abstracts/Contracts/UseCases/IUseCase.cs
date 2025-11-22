using Stokify.Application.Abstracts.Markers;
using Stokify.Application.Abstracts.Result;

namespace Stokify.Application.Abstracts.Contracts.UseCases;

public interface IUseCase<TResult, TCommand> where TCommand : ICommand
{
    Result<TResult> ExecuteAsync(TCommand command);
}
