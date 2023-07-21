using MediatR;

namespace Application.Words.Commands.CreateWord
{
    public class CreateWordCommand : IRequest<Unit>
    {
        public string Name { get; set; }
        public string? Transcription { get; set; } = null;
        public string? Image { get; set; } = null;
        public ICollection<Translation> Translations { get; set; }
        public Guid WordListId { get; set; }
    }

    public class Translation
    {
        public string Name { get; set; }
        public string? Example { get; set; }
        public string PartOfSpeech { get; set; }
    }
}
