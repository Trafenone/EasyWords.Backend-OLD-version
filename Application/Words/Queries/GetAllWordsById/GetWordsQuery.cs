using MediatR;

namespace Application.Words.Queries.GetAllWordsById
{
    public class GetWordsQuery : IRequest<WordVm>
    {
        public Guid Id { get; set; }
    }
}
