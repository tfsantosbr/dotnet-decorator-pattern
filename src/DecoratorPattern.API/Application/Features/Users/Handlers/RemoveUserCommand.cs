using DecoratorPattern.API.Application.Common.Handlers;

namespace DecoratorPattern.API.Application.Features.Users.Handlers;

public record RemoveUserCommand(Guid Id) : ICommand;
