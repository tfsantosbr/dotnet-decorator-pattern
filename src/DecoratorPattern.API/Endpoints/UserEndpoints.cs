using DecoratorPattern.API.Application.Common.Handlers;
using DecoratorPattern.API.Application.Features.Users.Handlers;
using DecoratorPattern.API.Models;

namespace DecoratorPattern.API.Endpoints;

public static class UserEndpoints
{
    public static void MapUserEndpoints(this IEndpointRouteBuilder builder)
    {
        builder.MapPost("/users", CreateUser);
        builder.MapPut("/users/{userId}", UpdateUser);
        builder.MapDelete("/users/{userId}", RemoveUser);
    }

    private static IResult CreateUser(
        CreateUserCommand command, ICommandHandler<CreateUserCommand, CreateUserCommandResponse> handler)
    {
        var result = handler.Handle(command);

        if (result.IsFailure)
        {
            return Results.BadRequest(result.ErrorMessages);
        }

        return Results.Created($"users/{result.Data!.Id}", result.Data);
    }

    private static IResult UpdateUser(
        Guid userId, UpdateUserRequest request, ICommandHandler<UpdateUserCommand> handler)
    {
        var command = new UpdateUserCommand(userId, request.Name, request.Email);

        var result = handler.Handle(command);

        if (result.IsFailure)
        {
            return Results.BadRequest(result.ErrorMessages);
        }

        return Results.NoContent();
    }

    private static IResult RemoveUser(
        Guid userId, ICommandHandler<RemoveUserCommand> handler)
    {
        var result = handler.Handle(new RemoveUserCommand(userId));

        if (result.IsFailure)
        {
            return Results.BadRequest(result.ErrorMessages);
        }

        return Results.NoContent();
    }
}
