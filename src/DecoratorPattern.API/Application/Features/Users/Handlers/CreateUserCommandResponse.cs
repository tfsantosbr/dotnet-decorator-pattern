namespace DecoratorPattern.API.Application.Features.Users.Handlers;

public record CreateUserCommandResponse(Guid Id, string Name, string Email);