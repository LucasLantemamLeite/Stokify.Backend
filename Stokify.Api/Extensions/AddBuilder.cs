using Microsoft.EntityFrameworkCore;
using Stokify.Infrastructure.Data.Context;
using Stokify.Infrastructure.Shared.Extensions;

namespace Stokify.Api.Extensions;

public static partial class Inject
{
    extension(WebApplicationBuilder builder)
    {
        public WebApplicationBuilder AddBuilder()
        {
            var conn = builder.Configuration.GetConnectionString("Default");

            builder.Services.AddDbContext<AppDbContext>(options => options.UseNpgsql(conn));

            builder.Services
                .AddInfrastructure();

            return builder;
        }
    }
}