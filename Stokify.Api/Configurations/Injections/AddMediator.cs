using Stokify.Application.Abstractions.Contracts.Mediator;
using Stokify.Application.Mediator;
using Stokify.Application.Result;
using Stokify.Application.Users.Commands;
using Stokify.Application.Users.Handlers;
using Stokify.Domain.Users;

namespace Stokify.Api.Configurations.Injections;

public static partial class Injection
{
    public static IServiceCollection AddMediator(this IServiceCollection services)
    {
        services.AddSingleton<IMediator, Mediator>();

        services.AddScoped<IHandler<CreateUserCommand, Result<User>>, CreateUserHandler>();

        return services;
    }
}