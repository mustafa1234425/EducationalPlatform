using EducationalPlatform.Application.DTOs.Videos;
using MediatR;


namespace EducationalPlatform.Application.Features.Courses.Commands.CreateCourse
{
    public class UpdateCourseCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public List<CourseVideoDto> Videos { get; set; } = new List<CourseVideoDto>();
    }

}
