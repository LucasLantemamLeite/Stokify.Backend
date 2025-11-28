using Microsoft.AspNetCore.Mvc;

namespace Stokify.Api.Configurations.Builder;

public static class BuilderConfig
{
    public static WebApplicationBuilder ApplyConfig(this WebApplicationBuilder builder)
    {
        builder.Services.Configure<ApiBehaviorOptions>(options => options.SuppressModelStateInvalidFilter = true);

        builder.Services.AddHealthChecks();

        builder.Services.AddControllers();

        return builder;
    }
}