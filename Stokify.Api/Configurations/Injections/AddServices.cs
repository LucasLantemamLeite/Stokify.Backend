using Microsoft.EntityFrameworkCore;
using Stokify.Application.Shared.Contracts.WorkUnit;
using Stokify.Infrastructure.Data.Context;
using Stokify.Infrastructure.WorkUnit;

namespace Stokify.Api.Configurations.Injections;

public static partial class Injection
{
    public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DefaultConnection");

        services.AddDbContext<AppDbContext>(x => x.UseNpgsql(connectionString));
        services.AddScoped<IWorkOfUnit, WorkOfUnit>();

        return services;
    }
}