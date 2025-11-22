using Microsoft.EntityFrameworkCore;
using Stokify.Application.Abstracts.Contracts.WorkUnit;
using Stokify.Infrastructure.Concrete.WorkUnit;
using Stokify.Infrastructure.Data.Context;

namespace Stokify.Api.Configuration.Injections;

public static partial class Injection
{
    public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration config)
    {
        var connectionString = config.GetConnectionString("DefaultConnection");

        services.AddDbContext<AppDbContext>(options => options.UseNpgsql(connectionString));

        services.AddScoped<IWorkOfUnit, WorkOfUnit>();

        return services;
    }
}