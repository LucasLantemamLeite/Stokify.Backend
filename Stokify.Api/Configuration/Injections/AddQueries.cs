using Stokify.Application.Abstracts.Contracts.Queries;
using Stokify.Infrastructure.Concrete.Queries;

namespace Stokify.Api.Configuration.Injections;

public static partial class Injection
{
    public static IServiceCollection AddQueries(this IServiceCollection services)
    {
        services.AddScoped<IUserQuery, UserQuery>();

        return services;
    }
}