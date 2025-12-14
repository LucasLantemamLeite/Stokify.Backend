using Microsoft.Extensions.DependencyInjection;
using Stokify.Application.Users.Contracts.Repositories;
using Stokify.Infrastructure.Users.Repositories;

namespace Stokify.Infrastructure.Shared.Extensions;

public static class Inject
{
    extension(IServiceCollection services)
    {
        public IServiceCollection AddInfrastructure()
        {
            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}