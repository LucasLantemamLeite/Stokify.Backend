using Stokify.Application.Abstractions.Contracts.Mediator;

namespace Stokify.Application.Mediator;

public sealed class Mediator : IMediator
{
    private readonly IServiceProvider _provider;

    public Mediator(IServiceProvider provider)
        => _provider = provider;

    public Task<TResponse> Send<TResponse>(IRequest<TResponse> request, CancellationToken token)
    {
        var requestType = request.GetType();

        var handlerType = typeof(IHandler<,>).MakeGenericType(requestType, typeof(TResponse));

        dynamic handler = _provider.GetService(handlerType) ?? throw new Exception($"Handler not found for {requestType.Name}");

        return handler.Handle((dynamic)request);
    }
}