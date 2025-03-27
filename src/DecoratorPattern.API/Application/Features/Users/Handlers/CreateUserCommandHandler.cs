using DecoratorPattern.API.Application.Common.Handlers;
using DecoratorPattern.API.Application.Common.Results;

namespace DecoratorPattern.API.Application.Features.Users.Handlers;

public class CreateUserCommandHandler(ILogger<CreateUserCommandHandler> logger)
    : ICommandHandler<CreateUserCommand, CreateUserCommandResponse>
{
    public Result<CreateUserCommandResponse> Handle(CreateUserCommand request)
    {
        logger.LogInformation("Creating user {Name} with email {Email}", request.Name, request.Email);

        var createdUserResponse = new CreateUserCommandResponse(Guid.CreateVersion7(), request.Name, request.Email);

        logger.LogInformation("User '{Name}' with email '{Email}' created with success! User Id is '{Id}'",
            createdUserResponse.Name, createdUserResponse.Email, createdUserResponse.Id);

        return Result.Success(createdUserResponse);
    }
}
