using Application.Common.Exceptions;
using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;

namespace Application.Words.Commands.UpdateWord
{
    public class UpdateWordCommandHandler : IRequestHandler<UpdateWordCommand, Unit>
    {
        private readonly IApplicationDbContext _context;

        public UpdateWordCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateWordCommand request, CancellationToken cancellationToken)
        {
            var entity = _context.Words
                .Where(w => w.Id == request.Id)
                .SingleOrDefault();

            if (entity == null)
                throw new NotFoundException(nameof(Word), request.Id);

            entity.Name = request.Name;
            entity.Transcription = request.Transcription;
            entity.Image = request.Image;

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
