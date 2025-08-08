using EducationalPlatform.Application.DTOs.Book;
using MediatR;


namespace EducationalPlatform.Application.Features.Books.Queries
{
    public class GetBookByIdWithCategoryQuery : IRequest<GetBookWithCategoryDto>
    {
        public int Id { get; set; }

        public GetBookByIdWithCategoryQuery(int id)
        {
            Id = id; 
        }
    }

}
