using MediatR;

namespace Application.WordLists.Commands.CreateWordList
{
    public class CreateWordListCommand : IRequest<Unit>
    {
        public string Title { get; set; }
    }
}
