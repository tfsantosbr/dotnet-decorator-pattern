using DecoratorPattern.API.Application.Common.Decorators;
using DecoratorPattern.API.Application.Common.Handlers;
using DecoratorPattern.API.Application.Features.Users.Handlers;
using FluentValidation;

namespace DecoratorPattern.API.Extensions;

public static class ApplicationExtensions
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        // add handlers

        services.AddScoped<CreateUserCommandHandler>();
        services.AddScoped<ICommandHandler<CreateUserCommand, CreateUserCommandResponse>>(provider =>
        {
            var handler = provider.GetRequiredService<CreateUserCommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<CreateUserCommand, CreateUserCommandResponse>>>();
            var loggingDecorator = new LoggingDecorator<CreateUserCommand, CreateUserCommandResponse>(handler, logger);
            var validator = provider.GetRequiredService<IValidator<CreateUserCommand>>();
            var validationDecorator = new ValidationDecorator<CreateUserCommand, CreateUserCommandResponse>(loggingDecorator, logger, validator);

            return validationDecorator;
        });

        services.AddScoped<UpdateUserCommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserCommand>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserCommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserCommand>>>();
            var loggingDecorator = new LoggingDecorator<UpdateUserCommand>(handler, logger);
            var validator = provider.GetRequiredService<IValidator<UpdateUserCommand>>();
            var validationDecorator = new ValidationDecorator<UpdateUserCommand>(loggingDecorator, logger, validator);

            return validationDecorator;
        });

        return services;
    }
}
