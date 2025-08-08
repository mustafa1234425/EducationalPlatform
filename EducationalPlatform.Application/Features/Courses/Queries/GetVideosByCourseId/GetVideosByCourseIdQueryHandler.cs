using AutoMapper;
using EducationalPlatform.Application.Features.Courses.Commands.CreateCourse;
using EducationalPlatform.Application.Interfaces;
using MediatR;


namespace EducationalPlatform.Application.Features.Courses.Queries.GetVideosByCourseId
{
    public class GetVideosByCourseIdQueryHandler : IRequestHandler<GetVideosByCourseIdQuery, List<CourseVideoDto>>
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMapper _mapper;

        public GetVideosByCourseIdQueryHandler(ICourseRepository courseRepository, IMapper mapper)
        {
            _courseRepository = courseRepository;
            _mapper = mapper;
        }

        public async Task<List<CourseVideoDto>> Handle(GetVideosByCourseIdQuery request, CancellationToken cancellationToken)
        {
           
            var videos = await _courseRepository.GetVideosByCourseIdAsync(request.CourseId);

           
            return _mapper.Map<List<CourseVideoDto>>(videos);
        }
    }

}
