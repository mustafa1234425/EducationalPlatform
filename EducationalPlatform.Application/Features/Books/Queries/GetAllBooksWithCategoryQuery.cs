using EducationalPlatform.Application.DTOs.Book;
using MediatR;


namespace EducationalPlatform.Application.Features.Books.Queries
{
    public class GetAllBooksWithCategoryQuery : IRequest<List<GetBookWithCategoryDto>>
    {
    }

}
