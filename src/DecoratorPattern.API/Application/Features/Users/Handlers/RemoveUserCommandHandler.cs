using DecoratorPattern.API.Application.Common.Handlers;
using DecoratorPattern.API.Application.Common.Results;

namespace DecoratorPattern.API.Application.Features.Users.Handlers;

public class RemoveUserCommandHandler(ILogger<RemoveUserCommandHandler> logger)
    : ICommandHandler<RemoveUserCommand>
{
    public Result Handle(RemoveUserCommand request)
    {
        logger.LogInformation("Removing user with id '{Id}'", request.Id);

        logger.LogInformation("User with id '{Id}' removed!", request.Id);

        return Result.Success();
    }
}