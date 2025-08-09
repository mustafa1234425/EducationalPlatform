using MediatR;


namespace EducationalPlatform.Application.Features.CourseVideos.Commands
{
    public class DeleteCourseVideoCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }

}
