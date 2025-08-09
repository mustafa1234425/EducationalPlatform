using EducationalPlatform.Application.Interfaces;
using MediatR;


namespace EducationalPlatform.Application.Features.Articles.Commands
{
    public class UpdateArticleCommandHandler : IRequestHandler<UpdateArticleCommand, bool>
    {
        private readonly IArticleRepository _repository;

        public UpdateArticleCommandHandler(IArticleRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> Handle(UpdateArticleCommand request, CancellationToken cancellationToken)
        {
            var article = await _repository.GetByIdAsync(request.Id);
            if (article == null) return false;

            article.Title = request.ArticleDto.Title;
            article.HtmlContent = request.ArticleDto.HtmlContent;
            article.CategoryId = request.ArticleDto.CategoryId;

            await _repository.UpdateAsync(article);
            return true;
        }
    }

}
