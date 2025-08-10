

using System.ComponentModel.DataAnnotations;

namespace EducationalPlatform.Application.DTOs.Category
{
    public class UpdateCategoryDto {

        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public int? ParentCategoryId { get; set; }
    }

}
