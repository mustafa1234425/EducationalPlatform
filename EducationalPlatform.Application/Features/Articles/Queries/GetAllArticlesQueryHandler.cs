using AutoMapper;
using EducationalPlatform.Application.DTOs.Article;
using EducationalPlatform.Application.Interfaces;
using MediatR;


namespace EducationalPlatform.Application.Features.Articles.Queries
{
    public class GetAllArticlesQueryHandler : IRequestHandler<GetAllArticlesQuery, List<ArticleDto>>
    {
        private readonly IArticleRepository _repository;
        private readonly IMapper _mapper;

        public GetAllArticlesQueryHandler(IArticleRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<ArticleDto>> Handle(GetAllArticlesQuery request, CancellationToken cancellationToken)
        {
            var articles = await _repository.GetAllWithCategoryAsync();
            return _mapper.Map<List<ArticleDto>>(articles);
        }
    }

}
