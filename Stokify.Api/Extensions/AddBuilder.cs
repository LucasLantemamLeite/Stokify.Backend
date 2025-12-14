using Microsoft.EntityFrameworkCore;
using Stokify.Infrastructure.Data.Context;

namespace Stokify.Api.Extensions;

public static partial class Inject
{
    extension(WebApplicationBuilder builder)
    {
        public WebApplicationBuilder AddBuilder()
        {
            var conn = builder.Configuration.GetConnectionString("Default");

            builder.Services.AddDbContext<AppDbContext>(options => options.UseNpgsql(conn));

            return builder;
        }
    }
}