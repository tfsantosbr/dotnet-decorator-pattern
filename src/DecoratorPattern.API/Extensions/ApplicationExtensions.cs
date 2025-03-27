using DecoratorPattern.API.Application.Features.Users.Handlers;
using FluentValidation;

namespace DecoratorPattern.API.Extensions;

public static class ApplicationExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        // validator

        services.AddValidatorsFromAssemblyContaining<CreateUserCommandResponse>();

        // handlers

        services.AddDecoratedHandler<CreateUserCommand, CreateUserCommandResponse, CreateUserCommandHandler>();
        services.AddDecoratedHandler<UpdateUserCommand, UpdateUserCommandHandler>();
        services.AddDecoratedHandler<RemoveUserCommand, RemoveUserCommandHandler>();

        return services;
    }
}
