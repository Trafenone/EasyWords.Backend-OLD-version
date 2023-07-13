using FluentValidation;

namespace Application.WordLists.Commands.CreateWordList
{
    public class CreateWordListCommandValidator : AbstractValidator<CreateWordListCommand>
    {
        public CreateWordListCommandValidator()
        {
            RuleFor(createCommand =>
                createCommand.Title).NotEmpty().MinimumLength(5);
        }
    }
}
