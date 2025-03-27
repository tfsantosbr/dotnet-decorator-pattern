using System.Diagnostics;
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

        // add handlers (forma automática com a lib Scrutor)
        // AddHandlersAutomaticaly(services);

        // add handlers (forma manual)
        AddHandlersNative(services);

        return services;
    }

    private static void AddHandlersAutomaticaly(IServiceCollection services)
    {
        var watch = Stopwatch.StartNew();

        // Registra o handler e aplica os decorators para o CreateUserCommand
        services.AddScoped<ICommandHandler<CreateUserCommand, CreateUserCommandResponse>, CreateUserCommandHandler>();
        services.Decorate<ICommandHandler<CreateUserCommand, CreateUserCommandResponse>, ValidationDecorator<CreateUserCommand, CreateUserCommandResponse>>();
        services.Decorate<ICommandHandler<CreateUserCommand, CreateUserCommandResponse>, LoggingDecorator<CreateUserCommand, CreateUserCommandResponse>>();

        // Registra o handler e aplica os decorators para o UpdateUserCommand
        services.AddScoped<ICommandHandler<UpdateUserCommand>, UpdateUserCommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserCommand>, ValidationDecorator<UpdateUserCommand>>();
        services.Decorate<ICommandHandler<UpdateUserCommand>, LoggingDecorator<UpdateUserCommand>>();

        // Registra o handler e aplica os decorators para o RemoveUserCommand
        services.AddScoped<ICommandHandler<RemoveUserCommand>, RemoveUserCommandHandler>();
        services.Decorate<ICommandHandler<RemoveUserCommand>, ValidationDecorator<RemoveUserCommand>>();
        services.Decorate<ICommandHandler<RemoveUserCommand>, LoggingDecorator<RemoveUserCommand>>();

        watch.Stop();
        Console.WriteLine($"Handlers registered in {watch.ElapsedMilliseconds}ms");
    }

    private static void AddHandlersNative(IServiceCollection services)
    {
        var watch = Stopwatch.StartNew();

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

        watch.Stop();
        Console.WriteLine($"Handlers registered in {watch.ElapsedMilliseconds}ms");
    }
}
