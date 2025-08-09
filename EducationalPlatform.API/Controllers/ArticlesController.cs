using EducationalPlatform.Application.DTOs.Article;
using EducationalPlatform.Application.Features.Articles.Commands;
using EducationalPlatform.Application.Features.Articles.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EducationalPlatform.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ArticlesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ArticlesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateArticleDto dto)
        {
            var id = await _mediator.Send(new CreateArticleCommand { ArticleDto = dto });
            return Ok(new { success = true, id });
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var articles = await _mediator.Send(new GetAllArticlesQuery());
            return Ok(new { success = true, data = articles });
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] CreateArticleDto dto)
        {
            var result = await _mediator.Send(new UpdateArticleCommand { Id = id, ArticleDto = dto });
            if (!result) return NotFound(new { success = false, message = "Article not found" });
            return Ok(new { success = true });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _mediator.Send(new DeleteArticleCommand { Id = id });
            if (!result) return NotFound(new { success = false, message = "Article not found" });
            return Ok(new { success = true });
        }
    }

}
