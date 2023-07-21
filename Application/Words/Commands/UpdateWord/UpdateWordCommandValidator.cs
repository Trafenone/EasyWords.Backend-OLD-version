using FluentValidation;

namespace Application.Words.Commands.UpdateWord
{
    public class UpdateWordCommandValidator : AbstractValidator<UpdateWordCommand>
    {
        public UpdateWordCommandValidator()
        {
            RuleFor(updateCommand => updateCommand.Id).NotEqual(Guid.Empty);
            RuleFor(updateCommand => updateCommand.Name).NotEmpty().MaximumLength(255);
        }
    }
}
