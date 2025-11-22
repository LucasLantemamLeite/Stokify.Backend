using Stokify.Application.Abstracts.Contracts.UseCases.Users;
using Stokify.Infrastructure.Concrete.UseCases.Users;

namespace Stokify.Api.Configuration.Injections;

public static partial class Injection
{
    public static IServiceCollection AddUseCases(this IServiceCollection services)
    {
        services.AddScoped<ICreateUserUseCase, CreateUserUseCase>();

        return services;
    }
}