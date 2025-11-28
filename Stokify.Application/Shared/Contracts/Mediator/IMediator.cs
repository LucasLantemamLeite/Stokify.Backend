namespace Stokify.Application.Abstractions.Contracts.Mediator;

public interface IMediator
{
    Task<TResponse> Send<TResponse>(IRequest<TResponse> request, CancellationToken token);
}