using Stokify.Application.Abstracts.Contracts.Repositories;
using Stokify.Infrastructure.Concrete.Repositories;

namespace Stokify.Api.Configuration.Injections;

public static partial class Injection
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IUserRepository, UserRepository>();

        return services;
    }
}