using DecoratorPattern.API.Application.Common.Results;

namespace DecoratorPattern.API.Application.Common.Handlers;

public interface ICommandHandler<TRequest, TResponse>
    where TRequest : ICommand<TResponse>
{
    Result<TResponse> Handle(TRequest request);
}

public interface ICommandHandler<TRequest>
    where TRequest : ICommand
{
    Result Handle(TRequest request);
}