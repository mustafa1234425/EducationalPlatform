using EducationalPlatform.Application.Interfaces;
using EducationalPlatform.Domain.Entities;
using MediatR;


namespace EducationalPlatform.Application.Features.Courses.Queries.GetAllCourses
{
    public class GetCourseByIdQueryHandler : IRequestHandler<GetCourseByIdQuery, Course>
    {
        private readonly ICourseRepository _repository; 
        public GetCourseByIdQueryHandler(ICourseRepository repository)
        {
            _repository = repository; 
        }

        public async Task<Course> Handle(GetCourseByIdQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetByIdAsync(request.Id);
        }
    }

}
