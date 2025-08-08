using EducationalPlatform.Domain.Common;

namespace EducationalPlatform.Domain.Entities
{
    public class Tag : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<CourseTag> CourseTag { get; set; }
    }
}
