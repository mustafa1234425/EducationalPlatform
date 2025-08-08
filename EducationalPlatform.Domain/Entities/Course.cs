using EducationalPlatform.Domain.Common;
using EducationalPlatform.Domain.Enums;

namespace EducationalPlatform.Domain.Entities
{
    public class Course : BaseEntity
    {
        public string Title { get; set; }

        public string? Description { get; set; }

        public string? ImageUrl { get; set; }

        public CourseLevel? Level { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public ICollection<CourseVideo>? Videos { get; set; }

        public ICollection<CourseTag>? CourseTags { get; set; }
    }
}
