namespace Stokify.Api.Configurations.App;

public static class AppConfig
{
    public static WebApplication ApplyConfig(this WebApplication app)
    {
        app.UseHttpsRedirection();

        app.UseRouting();

        app.UseHealthChecks("/v1/health");

        app.MapControllers();

        return app;
    }
}