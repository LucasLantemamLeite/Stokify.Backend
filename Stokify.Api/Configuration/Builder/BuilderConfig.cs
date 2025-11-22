using Microsoft.AspNetCore.Mvc;

namespace Stokify.Api.Configuration.Builder;

public static class BuilderConfig
{
    public static WebApplicationBuilder ApplyConfig(this WebApplicationBuilder builder)
    {
        builder.Services.AddHealthChecks();

        builder.Services.Configure<ApiBehaviorOptions>(options => options.SuppressModelStateInvalidFilter = true);

        if (builder.Environment.IsDevelopment())
        {
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
        }

        builder.Services.AddControllers();

        return builder;
    }
}