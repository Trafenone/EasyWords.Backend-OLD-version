using MediatR;

namespace Application.Words.Commands.DeleteWord
{
    public class DeleteWordCommand : IRequest<Unit>
    {
        public Guid Id { get; set; }
    }
}
