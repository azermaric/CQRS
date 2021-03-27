using FluentValidation;
using FluentValidation.Results;

namespace CQRS.Application.Infrastructure.FluentValidation
{
    /// <summary>
    /// Base implementation for AbstractValidator that ensures that model was supplied, otherwise the library will throw
    /// </summary>
    public class ValidatorBase<T> : AbstractValidator<T>
    {
        protected override bool PreValidate(ValidationContext<T> context, ValidationResult result)
        {
            if (context.InstanceToValidate == null)
            {
                result.Errors.Add(new ValidationFailure(string.Empty, "Model was not supplied."));
                return false;
            }

            return true;
        }
    }
}
