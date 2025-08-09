

namespace EducationalPlatform.Application.DTOs.Videos
{
    public class CreateCourseVideoDto
    {
        public int CourseId { get; set; }

        public string Title { get; set; }

        public string VideoUrl { get; set; }

        public int Order { get; set; }

        public TimeSpan Duration { get; set; }
    }

}
