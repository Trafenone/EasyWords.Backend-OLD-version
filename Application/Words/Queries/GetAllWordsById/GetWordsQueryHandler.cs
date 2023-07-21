using Application.Common.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Words.Queries.GetAllWordsById
{
    public class GetWordsQueryHandler : IRequestHandler<GetWordsQuery, WordVm>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetWordsQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<WordVm> Handle(GetWordsQuery request, CancellationToken cancellationToken)
        {
            var query = await _context.Words
                .Where(w => w.WordListId == request.Id)
                .Include(w => w.Progress)
                .Include(w => w.WordList)
                .Include(w => w.Translations)
                .ProjectTo<WordDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            return new WordVm { Words = query };
        }
    }
}
