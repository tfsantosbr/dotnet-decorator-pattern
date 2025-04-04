using DecoratorPattern.API.Application.Common.Handlers;
using DecoratorPattern.API.Application.Common.Results;
using FluentValidation;

namespace DecoratorPattern.API.Application.Common.Decorators;

public class ValidationDecorator<TCommand, TResponse>(
    ICommandHandler<TCommand, TResponse> next,
    ILogger<LoggingDecorator<TCommand, TResponse>> logger,
    IValidator<TCommand> validator)
    : HandlerDecorator<TCommand, TResponse>(next) where TCommand : ICommand<TResponse>
{
    public override Result<TResponse> Handle(TCommand command)
    {
        logger.LogInformation("Validating request data.");

        var validationResult = validator.Validate(command);

        if (!validationResult.IsValid)
        {
            logger.LogWarning("The are validation errors in request data!");

            return Result<TResponse>.Failure([.. validationResult.Errors.Select(e => e.ErrorMessage)]);
        }

        return base.Handle(command);
    }
}

public class ValidationDecorator<TCommand>(
    ICommandHandler<TCommand> next,
    ILogger<LoggingDecorator<TCommand>> logger,
    IValidator<TCommand> validator)
    : HandlerDecorator<TCommand>(next) where TCommand : ICommand
{
    public override Result Handle(TCommand command)
    {
        logger.LogInformation("Validating request data");

        var validationResult = validator.Validate(command);

        if (!validationResult.IsValid)
        {
            logger.LogWarning("The are validation errors in request data!");

            return Result.Failure([.. validationResult.Errors.Select(e => e.ErrorMessage)]);
        }

        return base.Handle(command);
    }
}