using EducationalPlatform.Application.DTOs.Article;
using MediatR;


namespace EducationalPlatform.Application.Features.Articles.Queries
{
    public class GetAllArticlesQuery : IRequest<List<ArticleDto>> { }

}
