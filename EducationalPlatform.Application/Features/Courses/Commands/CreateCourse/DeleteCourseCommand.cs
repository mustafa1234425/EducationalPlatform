using MediatR;


namespace EducationalPlatform.Application.Features.Courses.Commands.CreateCourse
{
    public class DeleteCourseCommand : IRequest<bool>
    {
        public int Id { get; set; } 

        
        public DeleteCourseCommand(int id)
        {
            Id = id; 
        }
    }

}
