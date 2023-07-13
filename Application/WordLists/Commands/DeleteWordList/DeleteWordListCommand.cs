using MediatR;

namespace Application.WordLists.Commands.DeleteWordList
{
    public class DeleteWordListCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
