using EducationalPlatform.Application.DTOs.Videos;
using MediatR;


namespace EducationalPlatform.Application.Features.CourseVideos.Queries
{
    public class GetVideosByCourseIdQuery : IRequest<List<CourseVideoDto>>
    {
        public int CourseId { get; set; }
    }
}
