using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;

namespace Application.Words.Commands.CreateWord
{
    public class CreateWordCommandHandler : IRequestHandler<CreateWordCommand, Unit>
    {
        private readonly IApplicationDbContext _context;

        public CreateWordCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(CreateWordCommand request, CancellationToken cancellationToken)
        {
            Word word = new()
            {
                Name = request.Name,
                Transcription = request.Transcription,
                Image = request.Image,
                WordListId = request.WordListId,
                Progress = new Progress()
                {
                    CreationDate = DateTime.UtcNow,
                },
                Translations = request.Translations
                    .Select(t => new Domain.Entities.Translation
                    {
                        Name = t.Name,
                        Example = t.Example,
                        PartOfSpeech = t.PartOfSpeech
                    })
                    .ToList()
            };

            await _context.Words.AddAsync(word, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
