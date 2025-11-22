namespace Stokify.Api.Configuration.App;

public static class AppConfig
{
    public static WebApplication ApplyConfig(this WebApplication app)
    {
        app.UseHttpsRedirection();

        app.UseRouting();

        app.UseHealthChecks("/v1/health");

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.MapControllers();

        return app;
    }
}