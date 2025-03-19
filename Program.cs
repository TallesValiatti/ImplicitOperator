using ImplicitOperators;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<UserApplicationService>();
builder.Services.AddScoped<UserRepository>();
builder.Services.AddOpenApi();

var app = builder.Build();

app.UseHttpsRedirection();

app.MapGet("/users", async ([FromServices] UserApplicationService service ) => 
    await service.ListUsersAsync())
.WithName("ListUsers");

app.Run();