using MediatR;

namespace Application.WordLists.Commands.DeleteWordList
{
    public class DeleteWordListCommand : IRequest<Unit>
    {
        public Guid Id { get; set; }
    }
}
