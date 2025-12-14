namespace Stokify.Application.Shared.Contracts;

public interface IUseCase<TRequest, TResult>
{
    Task<TResult> ExecuteAsync(TRequest request, CancellationToken cancellationToken = default);
};