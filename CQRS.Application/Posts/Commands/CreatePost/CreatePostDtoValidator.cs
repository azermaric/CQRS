using CQRS.Application.Infrastructure.FluentValidation;
using FluentValidation;
using Microsoft.Extensions.Localization;

namespace CQRS.Application.Posts.Commands.CreatePost
{
    public class CreatePostDtoValidator : ValidatorBase<CreatePostCommand>
    {
        public CreatePostDtoValidator(IStringLocalizer<CreatePostDtoValidator> localizer)
        {
            //TODO: localize error messages
            RuleFor(r => r.Title).NotEmpty().WithMessage("Required field");
            RuleFor(r => r.Body).NotEmpty().WithMessage("Required field");
        }
    }
}
