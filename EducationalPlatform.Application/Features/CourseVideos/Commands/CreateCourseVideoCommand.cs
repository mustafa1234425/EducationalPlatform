using EducationalPlatform.Application.DTOs.Videos;
using MediatR;


namespace EducationalPlatform.Application.Features.CourseVideos.Commands
{
    public class CreateCourseVideoCommand : IRequest<int>
    {
        public CreateCourseVideoDto VideoDto { get; set; }
    }

}
