namespace Stokify.Application.Shared.Contracts.UseCases;

public interface IUseCase<TCommand, TResult>
{
    Task<TResult> ExecuteAsync(TCommand request);
}