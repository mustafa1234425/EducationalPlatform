using EducationalPlatform.Application.DTOs.Course;
using MediatR;


namespace EducationalPlatform.Application.Features.Courses.Commands.AddCourseVideos
{
    
    public class AddCourseVideoCommand : IRequest<int>
    {
        public int CourseId { get; set; }                 
        public AddCourseVideoDto VideoDto { get; set; }    

        public AddCourseVideoCommand(int courseId, AddCourseVideoDto videoDto)
        {
            CourseId = courseId;
            VideoDto = videoDto;
        }
    }

}
