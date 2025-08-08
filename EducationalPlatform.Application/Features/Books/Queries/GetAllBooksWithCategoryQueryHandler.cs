using EducationalPlatform.Application.DTOs.Book;
using EducationalPlatform.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalPlatform.Application.Features.Books.Queries
{
    public class GetAllBooksWithCategoryQueryHandler
        : IRequestHandler<GetAllBooksWithCategoryQuery, List<GetBookWithCategoryDto>>
    {
        private readonly IBookRepository _repository;

        public GetAllBooksWithCategoryQueryHandler(IBookRepository repository)
        {
            _repository = repository; 
        }

       
        public async Task<List<GetBookWithCategoryDto>> Handle(
            GetAllBooksWithCategoryQuery request,
            CancellationToken cancellationToken)
        {
            
            return await _repository.GetAllBooksWithCategoryAsync();
        }
    }

}
