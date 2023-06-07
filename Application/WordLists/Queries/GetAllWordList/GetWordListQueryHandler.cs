using Application.Common.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.WordLists.Queries.GetAllWordList
{
    public class GetWordListQueryHandler :
        IRequestHandler<GetWordListQuery, WordListVm>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetWordListQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<WordListVm> Handle(GetWordListQuery request, CancellationToken cancellationToken)
        {
            var query = await _context.WordLists
                .ProjectTo<WordListDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            return new WordListVm { WordLists = query };
        }
    }
}
