using BinhDinhFood.Application.Common.Models.User;
using FluentValidation;

namespace BinhDinhFood.Web.Validations;
public class UserSignInRequestValidation : AbstractValidator<UserSignInRequest>
{
    public UserSignInRequestValidation()
    {
        RuleFor(x => x.UserName).NotEmpty().MaximumLength(100);
    }
}
