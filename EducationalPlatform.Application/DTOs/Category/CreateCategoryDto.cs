

using System.ComponentModel.DataAnnotations;

namespace EducationalPlatform.Application.DTOs.Category
{
    public class CreateCategoryDto {

        [Required]
        public string Name { get; set; }
        public int? ParentCategoryId { get; set; }
    }

}
