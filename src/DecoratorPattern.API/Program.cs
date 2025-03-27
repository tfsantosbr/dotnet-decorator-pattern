using DecoratorPattern.API.Application.Features.Users.Handlers;
using FluentValidation;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddValidatorsFromAssemblyContaining<CreateUserCommandResponse>();


var app = builder.Build();

app.MapOpenApi();
app.UseHttpsRedirection();

app.Run();