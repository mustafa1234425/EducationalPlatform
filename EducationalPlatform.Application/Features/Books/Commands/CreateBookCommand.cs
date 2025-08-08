using EducationalPlatform.Application.DTOs.Book;
using MediatR;


namespace EducationalPlatform.Application.Features.Books.Commands
{
    public class CreateBookCommand : IRequest<int>
    {
        public CreateBookDto BookDto { get; set; }
    }
}

