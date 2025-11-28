using Stokify.Application.Abstractions.Contracts.Mediator;
using Stokify.Application.Mediator;
using Stokify.Application.Result;
using Stokify.Application.Users.Commands;
using Stokify.Application.Users.Contracts.UseCases;
using Stokify.Application.Users.Handlers;
using Stokify.Application.Users.UseCases;
using Stokify.Domain.Users;

namespace Stokify.Api.Configurations.Injections;

public static partial class Injection
{
    public static IServiceCollection AddUseCases(this IServiceCollection services)
    {
        services.AddScoped<ICreateUserUseCase, CreateUserUseCase>();

        return services;
    }
}