using DecoratorPattern.API.Application.Common.Handlers;
using DecoratorPattern.API.Application.Common.Results;
using FluentValidation;

namespace DecoratorPattern.API.Application.Common.Decorators;

public class ValidationDecorator<TCommand, TResponse>(
    ICommandHandler<TCommand, TResponse> next,
    ILogger<LoggingDecorator<TCommand, TResponse>> logger,
    IValidator<TCommand>? validator = default)
    : HandlerDecorator<TCommand, TResponse>(next) where TCommand : ICommand<TResponse>
{
    public override Result<TResponse> Handle(TCommand command)
    {
        logger.LogInformation("Validating command");

        if (validator is null)
        {
            return base.Handle(command);
        }

        var validationResult = validator.Validate(command);

        if (!validationResult.IsValid)
        {
            logger.LogWarning("Command is not valid.");

            return Result<TResponse>.Failure([.. validationResult.Errors.Select(e => e.ErrorMessage)]);
        }

        return base.Handle(command);
    }
}

public class ValidationDecorator<TCommand>(
    ICommandHandler<TCommand> next,
    ILogger<LoggingDecorator<TCommand>> logger,
    IValidator<TCommand>? validator = default)
    : HandlerDecorator<TCommand>(next) where TCommand : ICommand
{
    public override Result Handle(TCommand command)
    {
        logger.LogInformation("Validating command");

        if (validator is null)
        {
            return base.Handle(command);
        }

        var validationResult = validator.Validate(command);

        if (!validationResult.IsValid)
        {
            logger.LogWarning("Command is not valid.");

            return Result.Failure([.. validationResult.Errors.Select(e => e.ErrorMessage)]);
        }

        return base.Handle(command);
    }
}