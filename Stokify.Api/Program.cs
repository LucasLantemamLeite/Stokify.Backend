using Stokify.Api.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.AddBuilder();

var app = builder.Build();

app.AddApp();

app.Run();
