using EducationalPlatform.Application.DTOs.Book;
using MediatR;

namespace EducationalPlatform.Application.Features.Books.Commands
{
    public class UpdateBookCommand : IRequest<bool>
    {
        public UpdateBookDto Book { get; set; }

        public UpdateBookCommand(UpdateBookDto book)
        {
            Book = book;
        }
    }

}
