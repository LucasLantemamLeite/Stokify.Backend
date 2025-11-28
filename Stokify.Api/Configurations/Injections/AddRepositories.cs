using Microsoft.EntityFrameworkCore;
using Stokify.Application.Users.Contracts.Repositories;
using Stokify.Infrastructure.Data.Context;
using Stokify.Infrastructure.Users.Repository;

namespace Stokify.Api.Configurations.Injections;

public static partial class Injection
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IUserRepository, UserRepository>();

        return services;
    }
}