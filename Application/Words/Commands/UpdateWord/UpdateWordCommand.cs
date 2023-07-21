using MediatR;

namespace Application.Words.Commands.UpdateWord
{
    public class UpdateWordCommand : IRequest<Unit>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? Transcription { get; set; }
        public string? Image { get; set; }
    }
}
