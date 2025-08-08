using EducationalPlatform.Application.Features.Courses.Commands.CreateCourse;
using MediatR;


namespace EducationalPlatform.Application.Features.Courses.Queries.GetVideosByCourseId
{
    
    public class GetVideosByCourseIdQuery : IRequest<List<CourseVideoDto>>
    {
        public int CourseId { get; set; }

        public GetVideosByCourseIdQuery(int courseId)
        {
            CourseId = courseId;
        }
    }

}
