

namespace EducationalPlatform.Application.DTOs.Article
{
    public class ArticleDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string HtmlContent { get; set; }
        public string CategoryName { get; set; }
        public DateTime CreatedDate { get; set; }
    }

}
