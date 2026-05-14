using FluentValidation;
using Muraafiq.Application.Features.Auth.DTOs.Requests;

namespace Muraafiq.Application.Features.Auth.Validators;

public sealed class RegisterInternalValidator
    : AbstractValidator<RegisterInternalRequest>
{
    public RegisterInternalValidator()
    {
        RuleFor(x => x.FirstName)
            .NotEmpty()
            .MaximumLength(100);

        RuleFor(x => x.LastName)
            .NotEmpty()
            .MaximumLength(100);

        RuleFor(x => x.Email)
            .NotEmpty()
            .EmailAddress();

        RuleFor(x => x.Password)
            .NotEmpty()
            .MinimumLength(8);

        RuleFor(x => x.GenderId)
            .GreaterThan(0);

        RuleFor(x => x.RoleId)
            .GreaterThan(0);

        RuleFor(x => x.PreferredLanguageId)
            .GreaterThan(0);

        When(x => x.ProfileImage is not null, () =>
        {
            RuleFor(x => x.ProfileImage!.Length)
                .LessThanOrEqualTo(5 * 1024 * 1024);

            RuleFor(x => x.ProfileImage!.ContentType)
                .Must(x =>
                    x == "image/png" ||
                    x == "image/jpeg" ||
                    x == "image/jpg")
                .WithMessage("Invalid image type.");
        });
    }
}
