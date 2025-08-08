using MediatR;
using EducationalPlatform.Application.DTOs.Course;

namespace EducationalPlatform.Application.Features.Courses.Commands.CreateCourse
{
    public class CreateCourseCommand : IRequest<int>
    {
        public CreateCourseDto CourseDto { get; set; }

        public CreateCourseCommand(CreateCourseDto courseDto)
        {
            CourseDto = courseDto;
        }
    }
}
