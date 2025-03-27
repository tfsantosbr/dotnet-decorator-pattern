using DecoratorPattern.API.Application.Common.Handlers;
using DecoratorPattern.API.Application.Common.Results;

namespace DecoratorPattern.API.Application.Features.Users.Handlers;

public class RemoveUserCommandHandler(ILogger<RemoveUserCommandHandler> logger)
    : ICommandHandler<RemoveUserCommand>
{
    public Result Handle(RemoveUserCommand request)
    {
        logger.LogInformation("Removing user with id '{Id}'", request.Id);

        // Simulate a user not found
        if (request.Id == Guid.Parse("0195d618-af47-7731-bbf3-1fb332c57211"))
        {
            return Result.Failure(["User not found!"]);
        }

        logger.LogInformation("User with id '{Id}' removed!", request.Id);

        return Result.Success();
    }
}