using FluentValidation;
using Gml.Web.Api.Dto.Auth;
using Spectre.Console;

namespace Gml.Web.Api.Core.Auth;

public class PlayerAuthDtoValidator : AbstractValidator<BaseUserPassword>
{
    public PlayerAuthDtoValidator()
    {
        RuleFor(x => x.Login)
            .NotEmpty().WithMessage("Поле никнейма обязательно для заполнения.")
            .Length(3, 50).WithMessage("Ниекнейм должен содержать от 3 до 50 символов.");
    }
}
