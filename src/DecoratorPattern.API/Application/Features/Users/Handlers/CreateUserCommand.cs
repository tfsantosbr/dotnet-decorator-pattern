using DecoratorPattern.API.Application.Common.Handlers;

namespace DecoratorPattern.API.Application.Features.Users.Handlers;

public record CreateUserCommand(string Name, string Email) : ICommand<CreateUserCommandResponse>;
