using DecoratorPattern.API.Application.Common.Handlers;
using DecoratorPattern.API.Application.Common.Results;

namespace DecoratorPattern.API.Application.Features.Users.Handlers;

public class UpdateUserCommandHandler(ILogger<UpdateUserCommandHandler> logger)
    : ICommandHandler<UpdateUserCommand>
{
    public Result Handle(UpdateUserCommand request)
    {
        logger.LogInformation("Updating user {Name} with email {Email}", request.Name, request.Email);

        logger.LogInformation("User with id '{Id}' updated!", request.Id);

        return Result.Success();
    }
}
