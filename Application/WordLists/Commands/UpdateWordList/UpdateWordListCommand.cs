using MediatR;

namespace Application.WordLists.Commands.UpdateWordList
{
    public class UpdateWordListCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsActive { get; set; }
    }
}
