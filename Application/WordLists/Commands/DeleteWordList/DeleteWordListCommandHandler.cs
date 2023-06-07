using Application.Common.Exceptions;
using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.WordLists.Commands.DeleteWordList
{
    public class DeleteWordListCommandHandler
        : IRequestHandler<DeleteWordListCommand>
    {
        private readonly IApplicationDbContext _context;

        public DeleteWordListCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Handle(DeleteWordListCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.WordLists
                .Where(l => l.Id == request.Id)
                .SingleOrDefaultAsync(cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(WordList), request.Id);
            }

            _context.WordLists.Remove(entity);

            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
