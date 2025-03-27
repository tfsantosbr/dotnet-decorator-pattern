using System.Data;
using FluentValidation;

namespace DecoratorPattern.API.Application.Features.Users.Handlers;

public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
{
    public CreateUserCommandValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Name is required.")
            .MaximumLength(50).WithMessage("Name must not exceed 50 characters.");

        RuleFor(x => x.Email)
            .NotEmpty().WithMessage("Email is required.")
            .MaximumLength(50).WithMessage("Email must not exceed 50 characters.")
            .EmailAddress().WithMessage("Email is not valid.");
    }
}
