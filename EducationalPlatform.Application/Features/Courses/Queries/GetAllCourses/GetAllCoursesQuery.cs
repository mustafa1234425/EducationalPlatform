using MediatR;


namespace EducationalPlatform.Application.Features.Courses.Queries.GetAllCourses
{
    public class GetAllCoursesQuery : IRequest<List<CourseDto>> { }

}
