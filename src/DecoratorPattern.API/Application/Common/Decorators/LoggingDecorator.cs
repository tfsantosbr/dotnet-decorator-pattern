using DecoratorPattern.API.Application.Common.Handlers;
using DecoratorPattern.API.Application.Common.Results;

namespace DecoratorPattern.API.Application.Common.Decorators;

public class LoggingDecorator<TRequest, TResponse>(
    ICommandHandler<TRequest, TResponse> next, ILogger<LoggingDecorator<TRequest, TResponse>> logger)
    : HandlerDecorator<TRequest, TResponse>(next) where TRequest : ICommand<TResponse>
{
    public override Result<TResponse> Handle(TRequest request)
    {
        logger.LogInformation("Starting request {@Request}", request);

        var result = base.Handle(request);

        if (result.IsFailure)
        {
            logger.LogWarning("Finished request with errors '{@ErrorMessages}'", result.ErrorMessages);

            return result;
        }

        logger.LogInformation("Finished request with result '{@Result}'", result.Data);

        return result;
    }
}

public class LoggingDecorator<TRequest>(
    ICommandHandler<TRequest> next, ILogger<LoggingDecorator<TRequest>> logger)
    : HandlerDecorator<TRequest>(next) where TRequest : ICommand
{
    public override Result Handle(TRequest request)
    {
        logger.LogInformation("Starting request {@Request}", request);

        var result = base.Handle(request);

        if (result.IsFailure)
        {
            logger.LogWarning("Finished request with errors '{@ErrorMessage}'", result.ErrorMessages);

            return result;
        }

        logger.LogInformation("Finished request with success'");

        return result;
    }
}