using EducationalPlatform.Domain.Entities;
using MediatR;


namespace EducationalPlatform.Application.Features.Courses.Queries.GetAllCourses
{
    public class GetCourseByIdQuery : IRequest<Course>
    {
        public int Id { get; set; }

        public GetCourseByIdQuery(int id)
        {
            Id = id;
        }
    }

}
