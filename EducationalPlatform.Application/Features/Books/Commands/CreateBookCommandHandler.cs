using EducationalPlatform.Application.Interfaces;
using EducationalPlatform.Domain.Entities;
using MediatR;


namespace EducationalPlatform.Application.Features.Books.Commands
{
    public class CreateBookCommandHandler : IRequestHandler<CreateBookCommand, int>
    {
        private readonly IBookRepository _repository;

        
        public CreateBookCommandHandler(IBookRepository repository)
        {
            _repository = repository; 
        }

        
        public async Task<int> Handle(CreateBookCommand request, CancellationToken cancellationToken)
        {
         
            var book = new Book
            {
                Title = request.BookDto.Title,
                Description = request.BookDto.Description,
                PdfUrl = request.BookDto.PdfUrl,
                ImageUrl = request.BookDto.ImageUrl,
                CategoryId = request.BookDto.CategoryId
            };

           
            await _repository.AddAsync(book);

            
            return book.Id;
        }
    }

}
