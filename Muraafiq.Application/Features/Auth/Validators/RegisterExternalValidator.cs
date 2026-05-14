using FluentValidation;
using Muraafiq.Application.Features.Auth.DTOs.Requests;

namespace Muraafiq.Application.Features.Auth.Validators;

public sealed class RegisterExternalValidator
    : AbstractValidator<RegisterExternalRequest>
{
    public RegisterExternalValidator()
    {
        RuleFor(x => x.ProviderId)
            .GreaterThan(0);

        RuleFor(x => x.IdentityToken)
            .NotEmpty();

        RuleFor(x => x.RoleId)
            .GreaterThan(0);
    }
}
