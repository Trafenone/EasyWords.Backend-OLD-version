using FluentValidation;

namespace Application.WordLists.Commands.UpdateWordList
{
    public class UpdateWordListCommandValidator : AbstractValidator<UpdateWordListCommand>
    {
        public UpdateWordListCommandValidator()
        {
            RuleFor(updateCommand => updateCommand.Title).NotEmpty().MaximumLength(100);
        }
    }
}
