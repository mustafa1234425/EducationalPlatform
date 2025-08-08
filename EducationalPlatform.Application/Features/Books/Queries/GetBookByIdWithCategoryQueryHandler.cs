using EducationalPlatform.Application.DTOs.Book;
using EducationalPlatform.Application.Interfaces;
using MediatR;


namespace EducationalPlatform.Application.Features.Books.Queries
{
   
    public class GetBookByIdWithCategoryQueryHandler
        : IRequestHandler<GetBookByIdWithCategoryQuery, GetBookWithCategoryDto>
    {
       
        private readonly IBookRepository _repository;

        
        public GetBookByIdWithCategoryQueryHandler(IBookRepository repository)
        {
            _repository = repository;
        }

        
        public async Task<GetBookWithCategoryDto> Handle(
            GetBookByIdWithCategoryQuery request,
            CancellationToken cancellationToken)
        {
            
            return await _repository.GetBookByIdWithCategoryAsync(request.Id);
        }
    }

}
