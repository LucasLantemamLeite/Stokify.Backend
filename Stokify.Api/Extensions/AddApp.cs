namespace Stokify.Api.Extensions;

public static partial class Inject
{
    extension(WebApplication app)
    {
        public WebApplication AddApp()
        {
            return app;
        }
    }
}