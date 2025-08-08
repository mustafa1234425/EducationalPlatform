

namespace EducationalPlatform.Application.Features.Courses.Commands.CreateCourse
{
   
    public class CourseVideoDto
    {
        public int Id { get; set; }          
        public string Title { get; set; }     
        public string VideoUrl { get; set; } 
        public int Duration { get; set; } 
        public int Order { get; set; } 
    }

}
