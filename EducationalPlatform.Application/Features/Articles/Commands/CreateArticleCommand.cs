using EducationalPlatform.Application.DTOs.Article;
using MediatR;


namespace EducationalPlatform.Application.Features.Articles.Commands
{
    public class CreateArticleCommand : IRequest<int>
    {
        public CreateArticleDto ArticleDto { get; set; }
    }

}
