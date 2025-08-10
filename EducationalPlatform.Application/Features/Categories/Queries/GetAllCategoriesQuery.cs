using EducationalPlatform.Application.DTOs.Category;
using MediatR;


namespace EducationalPlatform.Application.Features.Categories.Queries
{
    public class GetAllCategoriesQuery : IRequest<List<CategoryDto>>
    {
    }
}
