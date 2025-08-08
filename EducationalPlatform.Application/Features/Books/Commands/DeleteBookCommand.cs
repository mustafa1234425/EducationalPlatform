using MediatR;


namespace EducationalPlatform.Application.Features.Books.Commands
{
    public class DeleteBookCommand : IRequest<bool>
    {
        public int Id { get; set; }

        public DeleteBookCommand(int id)
        {
            Id = id; 
        }
    }

}
