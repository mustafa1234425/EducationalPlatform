using EducationalPlatform.Application.DTOs.Category;
using MediatR;


namespace EducationalPlatform.Application.Features.Categories.Queries
{
    public class GetCategoryByIdQuery : IRequest<CategoryDto?>
    {
        public int Id { get; set; }
    }
}
