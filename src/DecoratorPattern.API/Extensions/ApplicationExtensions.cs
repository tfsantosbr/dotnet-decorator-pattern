using DecoratorPattern.API.Application.Common.Decorators;
using DecoratorPattern.API.Application.Common.Handlers;
using DecoratorPattern.API.Application.Features.Users.Handlers;
using FluentValidation;

namespace DecoratorPattern.API.Extensions;

public static class ApplicationExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        // validator

        services.AddValidatorsFromAssemblyContaining<CreateUserCommandResponse>();

        // add handlers

        services.AddScoped<CreateUserCommandHandler>();
        services.AddScoped<ICommandHandler<CreateUserCommand, CreateUserCommandResponse>>(provider =>
        {
            var handler = provider.GetRequiredService<CreateUserCommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<CreateUserCommand, CreateUserCommandResponse>>>();
            var validator = provider.GetRequiredService<IValidator<CreateUserCommand>>();
            var validationDecorator = new ValidationDecorator<CreateUserCommand, CreateUserCommandResponse>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<CreateUserCommand, CreateUserCommandResponse>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserCommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserCommand>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserCommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserCommand>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserCommand>>();
            var validationDecorator = new ValidationDecorator<UpdateUserCommand>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserCommand>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<RemoveUserCommandHandler>();
        services.AddScoped<ICommandHandler<RemoveUserCommand>>(provider =>
        {
            var handler = provider.GetRequiredService<RemoveUserCommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<RemoveUserCommand>>>();
            var validationDecorator = new ValidationDecorator<RemoveUserCommand>(handler, logger);
            var loggingDecorator = new LoggingDecorator<RemoveUserCommand>(handler, logger);

            return loggingDecorator;
        });

        return services;
    }
}
