using FluentValidation;

namespace Application.WordLists.Commands.DeleteWordList
{
    public class DeleteWordListCommandValidator : AbstractValidator<DeleteWordListCommand>
    {
        public DeleteWordListCommandValidator()
        {
            RuleFor(deleteCommand => deleteCommand.Id).NotEqual(Guid.Empty);
        }
    }
}
