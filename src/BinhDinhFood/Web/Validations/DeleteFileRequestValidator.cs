using BinhDinhFood.Application.Common.Models.Auth.File;
using FluentValidation;

namespace BinhDinhFood.Web.Validations;

public class DeleteFileRequestValidator : AbstractValidator<DeleteFileRequest>
{
    public DeleteFileRequestValidator()
    {
        RuleFor(x => x.FileName)
            .NotEmpty().WithMessage("FileName cannot be empty.")
            .NotNull().WithMessage("FileName cannot be null.")
            .Matches(@"^[a-zA-Z0-9_\-\.]+$").WithMessage("FileName contains invalid characters.");
    }
}
