using EducationalPlatform.Application.Interfaces;
using EducationalPlatform.Domain.Entities;
using MediatR;


namespace EducationalPlatform.Application.Features.Books.Commands
{
    public class UpdateBookCommandHandler : IRequestHandler<UpdateBookCommand, bool>
    {
        private readonly IBookRepository _repository;

        public UpdateBookCommandHandler(IBookRepository repository)
        {
            _repository = repository; 
        }

        public async Task<bool> Handle(UpdateBookCommand request, CancellationToken cancellationToken)
        {
            var book = new Book
            {
                Id = request.Book.Id,
                Title = request.Book.Title,
                Description = request.Book.Description,
                PdfUrl = request.Book.PdfUrl,
                ImageUrl = request.Book.ImageUrl,
                CategoryId = request.Book.CategoryId
            };

            return await _repository.UpdateAsync(book);
        }
    }

}
