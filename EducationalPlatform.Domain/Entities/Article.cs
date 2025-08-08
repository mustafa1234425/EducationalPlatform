using EducationalPlatform.Domain.Common;

namespace EducationalPlatform.Domain.Entities
{
    public class Article : BaseEntity
    {
        public string Title { get; set; }

        public string HtmlContent { get; set; }

        public string? AuthorName { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
