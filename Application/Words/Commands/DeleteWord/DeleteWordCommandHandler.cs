using Application.Common.Exceptions;
using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;

namespace Application.Words.Commands.DeleteWord
{
    public class DeleteWordCommandHandler : IRequestHandler<DeleteWordCommand, Unit>
    {
        private readonly IApplicationDbContext _context;

        public DeleteWordCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(DeleteWordCommand request, CancellationToken cancellationToken)
        {
            var entity = _context.Words
                .Where(w => w.Id == request.Id)
                .SingleOrDefault();

            if (entity == null)
                throw new NotFoundException(nameof(Word), request.Id);

            _context.Words.Remove(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
