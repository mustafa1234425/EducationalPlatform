using AutoMapper;
using MediatR;
using EducationalPlatform.Domain.Entities;
using EducationalPlatform.Application.Interfaces;

namespace EducationalPlatform.Application.Features.Courses.Commands.CreateCourse
{
    public class CreateCourseCommandHandler : IRequestHandler<CreateCourseCommand, int>
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMapper _mapper;

        public CreateCourseCommandHandler(ICourseRepository courseRepository, IMapper mapper)
        {
            _courseRepository = courseRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateCourseCommand request, CancellationToken cancellationToken)
        {
            var course = _mapper.Map<Course>(request.CourseDto);

            await _courseRepository.AddAsync(course);
            await _courseRepository.SaveChangesAsync();

            return course.Id;
        }
    }
}
