var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddProductModule(builder.Configuration);

var app = builder.Build();

app.UseProductModule();

app.Run();
