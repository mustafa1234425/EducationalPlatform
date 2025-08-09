using EducationalPlatform.Application.Interfaces;
using EducationalPlatform.Domain.Entities;
using MediatR;


namespace EducationalPlatform.Application.Features.CourseVideos.Commands
{
    public class CreateCourseVideoCommandHandler : IRequestHandler<CreateCourseVideoCommand, int>
    {
        private readonly ICourseVideoRepository _repository;

        public CreateCourseVideoCommandHandler(ICourseVideoRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> Handle(CreateCourseVideoCommand request, CancellationToken cancellationToken)
        {
            var video = new CourseVideo
            {
                CourseId = request.VideoDto.CourseId,
                Title = request.VideoDto.Title,
                VideoUrl = request.VideoDto.VideoUrl,
                Order = request.VideoDto.Order,
                Duration = request.VideoDto.Duration
            };

            await _repository.AddAsync(video);

            return video.Id;
        }
    }

}
