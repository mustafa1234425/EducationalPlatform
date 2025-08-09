using EducationalPlatform.Application.DTOs.Article;
using MediatR;


namespace EducationalPlatform.Application.Features.Articles.Commands
{
    public class UpdateArticleCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public CreateArticleDto ArticleDto { get; set; }
    }

}
