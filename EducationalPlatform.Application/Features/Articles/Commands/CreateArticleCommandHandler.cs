using EducationalPlatform.Application.Interfaces;
using EducationalPlatform.Domain.Entities;
using MediatR;


namespace EducationalPlatform.Application.Features.Articles.Commands
{
    public class CreateArticleCommandHandler : IRequestHandler<CreateArticleCommand, int>
    {
        private readonly IArticleRepository _repository;

        public CreateArticleCommandHandler(IArticleRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> Handle(CreateArticleCommand request, CancellationToken cancellationToken)
        {
            var article = new Article
            {
                Title = request.ArticleDto.Title,
                HtmlContent = request.ArticleDto.HtmlContent,
                CategoryId = request.ArticleDto.CategoryId,
                CreatedDate = DateTime.UtcNow
            };

            await _repository.AddAsync(article);

            return article.Id;
        }
    }

}
