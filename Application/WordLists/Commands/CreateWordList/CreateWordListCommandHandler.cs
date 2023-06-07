using Application.Common.Interfaces;
using MediatR;

namespace Application.WordLists.Commands.CreateWordList
{
    public class CreateWordListCommandHandler :
        IRequestHandler<CreateWordListCommand>
    {
        private readonly IApplicationDbContext _context;

        public CreateWordListCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Handle(CreateWordListCommand request, CancellationToken cancellationToken)
        {
            Domain.Entities.WordList list = new()
            {
                Title = request.Title,
            };

            await _context.WordLists.AddAsync(list, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
