using DecoratorPattern.API.Application.Common.Decorators;
using DecoratorPattern.API.Application.Common.Handlers;
using FluentValidation;

namespace DecoratorPattern.API.Extensions;

public static class DecoratedHandlersExtensions
{
    public static void AddDecoratedHandler<TCommand, TResponse, THandler>(this IServiceCollection services)
        where THandler : class, ICommandHandler<TCommand, TResponse>
        where TCommand : ICommand<TResponse>
    {
        services.AddTransient<THandler>();
        services.AddTransient(provider =>
        {
            var handler = provider.GetRequiredService<THandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<TCommand, TResponse>>>();
            var validator = provider.GetService<IValidator<TCommand>>();

            ICommandHandler<TCommand, TResponse> decoratedHandler = handler;

            if (validator != null)
            {
                decoratedHandler = new ValidationDecorator<TCommand, TResponse>(decoratedHandler, logger, validator);
            }

            decoratedHandler = new LoggingDecorator<TCommand, TResponse>(decoratedHandler, logger);

            return decoratedHandler;
        });
    }

    public static void AddDecoratedHandler<TCommand, THandler>(this IServiceCollection services)
        where THandler : class, ICommandHandler<TCommand>
        where TCommand : ICommand
    {
        services.AddTransient<THandler>();
        services.AddTransient(provider =>
        {
            var handler = provider.GetRequiredService<THandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<TCommand>>>();
            var validator = provider.GetService<IValidator<TCommand>>();

            ICommandHandler<TCommand> decoratedHandler = handler;

            if (validator != null)
            {
                decoratedHandler = new ValidationDecorator<TCommand>(decoratedHandler, logger, validator);
            }

            decoratedHandler = new LoggingDecorator<TCommand>(decoratedHandler, logger);

            return decoratedHandler;
        });
    }
}
