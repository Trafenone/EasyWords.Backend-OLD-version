using FluentValidation;

namespace Application.Words.Commands.CreateWord
{
    public class CreateWordCommandValidator : AbstractValidator<CreateWordCommand>
    {
        public CreateWordCommandValidator()
        {
            RuleFor(createCommand => createCommand.Name).NotEmpty().MaximumLength(255);
            RuleFor(createCommand => createCommand.WordListId).NotEqual(Guid.Empty);
            RuleFor(createCommand => createCommand.Translations).NotEmpty();
            RuleForEach(x => x.Translations).SetValidator(new TranslationsValidator());
        }
    }

    public class TranslationsValidator : AbstractValidator<Translation>
    {
        public TranslationsValidator()
        {
            RuleFor(createCommand => createCommand.Name).NotEmpty().MaximumLength(255);
            RuleFor(createCommand => createCommand.PartOfSpeech).NotEmpty().MaximumLength(100);
        }
    }
}
