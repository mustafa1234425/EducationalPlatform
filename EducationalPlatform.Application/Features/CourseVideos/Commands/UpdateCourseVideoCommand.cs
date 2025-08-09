using EducationalPlatform.Application.DTOs.Videos;
using MediatR;


namespace EducationalPlatform.Application.Features.CourseVideos.Commands
{
    public class UpdateCourseVideoCommand : IRequest<bool>
    {
        public UpdateCourseVideoDto VideoDto { get; set; }
    }

}
