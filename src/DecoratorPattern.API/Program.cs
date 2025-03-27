using DecoratorPattern.API.Endpoints;
using DecoratorPattern.API.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddApplicationServices();
builder.Services.AddSerilogServices();

var app = builder.Build();

app.MapOpenApi();
app.UseHttpsRedirection();
app.MapUserEndpoints();

app.Run();