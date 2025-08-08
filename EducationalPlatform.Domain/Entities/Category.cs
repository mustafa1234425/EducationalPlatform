using EducationalPlatform.Domain.Common;

namespace EducationalPlatform.Domain.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public int? ParentCategoryId { get; set; }
        public Category? ParentCategory { get; set; }
        public ICollection<Category> SubCategories { get; set; }

    }
}
