using EducationalPlatform.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalPlatform.Application.Features.CourseVideos.Commands
{
    public class UpdateCourseVideoCommandHandler : IRequestHandler<UpdateCourseVideoCommand, bool>
    {
        private readonly ICourseVideoRepository _repository;

        public UpdateCourseVideoCommandHandler(ICourseVideoRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> Handle(UpdateCourseVideoCommand request, CancellationToken cancellationToken)
        {
            var video = await _repository.GetByIdAsync(request.VideoDto.Id);
            if (video == null) return false;

            video.Title = request.VideoDto.Title;
            video.VideoUrl = request.VideoDto.VideoUrl;
            video.Order = request.VideoDto.Order;
            video.Duration = request.VideoDto.Duration;

            await _repository.UpdateAsync(video);

            return true;
        }
    }

}
