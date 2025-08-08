using MediatR;


namespace EducationalPlatform.Application.Features.Courses.Commands.CreateCourse
{
    public class UpdateCourseCommand : IRequest<bool>
    {
        public int Id { get; set; }          
        public string Title { get; set; }   
        public string Description { get; set; }
        public string VideoUrl { get; set; } 

        public UpdateCourseCommand(int id, string title, string description, string videoUrl)
        {
            Id = id;                
            Title = title;           
            Description = description; 
            VideoUrl = videoUrl;    
        }
    }

}
