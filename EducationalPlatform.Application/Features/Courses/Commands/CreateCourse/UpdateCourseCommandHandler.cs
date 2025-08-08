using EducationalPlatform.Application.Interfaces;
using EducationalPlatform.Domain.Entities;
using MediatR;


namespace EducationalPlatform.Application.Features.Courses.Commands.CreateCourse
{
    public class UpdateCourseCommandHandler : IRequestHandler<UpdateCourseCommand, bool>
    {
        private readonly ICourseRepository _repository;

        public UpdateCourseCommandHandler(ICourseRepository repository)
        {
            _repository = repository; 
        }

        public async Task<bool> Handle(UpdateCourseCommand request, CancellationToken cancellationToken)
        {
            var course = await _repository.GetByIdAsync(request.Id);

            if (course == null)
                return false;

            course.Title = request.Title;
            course.Description = request.Description;

            course.Videos.Clear();

            foreach (var videoDto in request.Videos)
            {
                course.Videos.Add(new CourseVideo
                {
                    VideoUrl = videoDto.VideoUrl
                });
            }

            return true;
        }
    }

}
