using Application.Common.Exceptions;
using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.WordLists.Commands.UpdateWordList
{
    public class UpdateWordListCommandHandler
        : IRequestHandler<UpdateWordListCommand, Unit>
    {
        private readonly IApplicationDbContext _context;

        public UpdateWordListCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateWordListCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.WordLists
                .FirstOrDefaultAsync(l => l.Id == request.Id, cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(WordList), request.Id);
            }

            entity.Title = request.Title;
            entity.IsActive = request.IsActive;

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
