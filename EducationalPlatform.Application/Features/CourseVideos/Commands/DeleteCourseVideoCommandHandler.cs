using EducationalPlatform.Application.Interfaces;
using MediatR;


namespace EducationalPlatform.Application.Features.CourseVideos.Commands
{
    public class DeleteCourseVideoCommandHandler : IRequestHandler<DeleteCourseVideoCommand, bool>
    {
        private readonly ICourseVideoRepository _repository;

        public DeleteCourseVideoCommandHandler(ICourseVideoRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> Handle(DeleteCourseVideoCommand request, CancellationToken cancellationToken)
        {
            var video = await _repository.GetByIdAsync(request.Id);
            if (video == null) return false;

            await _repository.DeleteAsync(video);
            return true;
        }
    }

}
