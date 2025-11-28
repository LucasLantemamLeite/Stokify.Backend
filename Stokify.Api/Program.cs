using Stokify.Api.Configurations.App;
using Stokify.Api.Configurations.Builder;
using Stokify.Api.Configurations.Injections;

var builder = WebApplication.CreateBuilder(args);

builder.ApplyConfig();

builder.Services
    .AddMediator()
    .AddUseCases()
    .AddRepositories()
    .AddServices(builder.Configuration);

var app = builder.Build();

app.ApplyConfig();

app.Run();
