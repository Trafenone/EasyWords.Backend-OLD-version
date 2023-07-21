using FluentValidation;

namespace Application.Words.Commands.DeleteWord
{
    public class DeleteWordCommandValidator : AbstractValidator<DeleteWordCommand>
    {
        public DeleteWordCommandValidator()
        {
            RuleFor(deleteCommand => deleteCommand.Id).NotEqual(Guid.Empty);
        }
    }
}
