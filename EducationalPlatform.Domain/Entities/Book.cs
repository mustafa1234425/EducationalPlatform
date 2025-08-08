using EducationalPlatform.Domain.Common;

namespace EducationalPlatform.Domain.Entities
{
    public class Book : BaseEntity
    {
        public string Title { get; set; }

        public string? Description { get; set; }

        public string PdfUrl { get; set; }

        public string? ImageUrl { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
