using DecoratorPattern.API.Application.Common.Handlers;

namespace DecoratorPattern.API.Application.Features.Users.Handlers;

public record UpdateUserCommand(Guid Id, string Name, string Email) : ICommand;
