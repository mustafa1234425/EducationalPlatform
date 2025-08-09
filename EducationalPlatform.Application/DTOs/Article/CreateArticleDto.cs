

namespace EducationalPlatform.Application.DTOs.Article
{
    public class CreateArticleDto
    {
        public string Title { get; set; }
        public string HtmlContent { get; set; }
        public int CategoryId { get; set; }
    }

}
