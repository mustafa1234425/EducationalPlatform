using MediatR;


namespace EducationalPlatform.Application.Features.Categories.Commands
{
    public class CreateCategoryCommand : IRequest<int> 
    {
        public string Name { get; set; }
        public int? ParentCategoryId { get; set; }
    }
}
