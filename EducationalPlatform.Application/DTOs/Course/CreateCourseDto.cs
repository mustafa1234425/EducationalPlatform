namespace EducationalPlatform.Application.DTOs.Course
{
    public class CreateCourseDto
    {
        public string Title { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public string? Level { get; set; }
        public int CategoryId { get; set; }
    }
}
