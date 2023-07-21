using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;

namespace Application.WordLists.Commands.CreateWordList
{
    public class CreateWordListCommandHandler :
        IRequestHandler<CreateWordListCommand, Unit>
    {
        private readonly IApplicationDbContext _context;

        public CreateWordListCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(CreateWordListCommand request, CancellationToken cancellationToken)
        {
            WordList list = new()
            {
                Title = request.Title,
            };

            await _context.WordLists.AddAsync(list, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
