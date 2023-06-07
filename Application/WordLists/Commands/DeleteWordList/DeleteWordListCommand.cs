using MediatR;

namespace Application.WordLists.Commands.DeleteWordList
{
    public class DeleteWordListCommand : IRequest
    {
        public int Id { get; set; }
    }
}
