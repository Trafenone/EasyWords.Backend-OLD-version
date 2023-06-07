using MediatR;

namespace Application.WordLists.Queries.GetAllWordList
{
    public class GetWordListQuery : IRequest<WordListVm>
    {
    }
}
