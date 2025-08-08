using AutoMapper;
using EducationalPlatform.Application.Interfaces;
using EducationalPlatform.Domain.Entities;
using MediatR;


namespace EducationalPlatform.Application.Features.Courses.Commands.CreateCourse
{
    public class AddCourseVideoCommandHandler : IRequestHandler<AddCourseVideoCommand, int>
    {
        private readonly IGenericRepository<CourseVideo> _videoRepo;
        private readonly IMapper _mapper;                            

        public AddCourseVideoCommandHandler(IGenericRepository<CourseVideo> videoRepo, IMapper mapper)
        {
            _videoRepo = videoRepo;
            _mapper = mapper;
        }

        public async Task<int> Handle(AddCourseVideoCommand request, CancellationToken cancellationToken)
        {
           
            var video = _mapper.Map<CourseVideo>(request.VideoDto);

            
            video.CourseId = request.CourseId;

          
            await _videoRepo.AddAsync(video);

           
            return video.Id;
        }
    }

}
