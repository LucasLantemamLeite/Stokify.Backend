using Stokify.Api.Configuration.App;
using Stokify.Api.Configuration.Builder;
using Stokify.Api.Configuration.Injections;

var builder = WebApplication.CreateBuilder(args);

builder.ApplyConfig();

builder.Services
    .AddQueries()
    .AddRepositories()
    .AddUseCases()
    .AddServices(builder.Configuration);

var app = builder.Build();

app.ApplyConfig();

app.Run();
