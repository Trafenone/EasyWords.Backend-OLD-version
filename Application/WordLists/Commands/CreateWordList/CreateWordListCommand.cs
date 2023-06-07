using MediatR;

namespace Application.WordLists.Commands.CreateWordList
{
    public class CreateWordListCommand : IRequest
    {
        public string Title { get; set; }
    }
}
