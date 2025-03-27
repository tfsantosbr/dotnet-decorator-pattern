using DecoratorPattern.API.Application.Common.Handlers;
using DecoratorPattern.API.Application.Common.Results;

namespace DecoratorPattern.API.Application.Common.Decorators;

public abstract class HandlerDecorator<TRequest, TResponse>(ICommandHandler<TRequest, TResponse> next)
    : ICommandHandler<TRequest, TResponse> where TRequest : ICommand<TResponse>
{
    public virtual Result<TResponse> Handle(TRequest request)
    {
        return next.Handle(request);
    }
}

public abstract class HandlerDecorator<TRequest>(ICommandHandler<TRequest> next)
    : ICommandHandler<TRequest> where TRequest : ICommand
{
    public virtual Result Handle(TRequest request)
    {
        return next.Handle(request);
    }
}
