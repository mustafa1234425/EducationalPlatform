using AutoMapper;
using EducationalPlatform.Application.Interfaces;
using MediatR;


namespace EducationalPlatform.Application.Features.Courses.Queries.GetAllCourses
{
    public class GetAllCoursesQueryHandler : IRequestHandler<GetAllCoursesQuery, List<CourseDto>>
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMapper _mapper;

        public GetAllCoursesQueryHandler(ICourseRepository courseRepository, IMapper mapper)
        {
            _courseRepository = courseRepository;
            _mapper = mapper;
        }

        public async Task<List<CourseDto>> Handle(GetAllCoursesQuery request, CancellationToken cancellationToken)
        {
            var courses = await _courseRepository.GetAllCoursesWithCategoryAsync();
            return _mapper.Map<List<CourseDto>>(courses);
        }
    }

}
