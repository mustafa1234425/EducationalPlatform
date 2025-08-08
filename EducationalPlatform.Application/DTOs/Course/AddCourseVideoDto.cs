

namespace EducationalPlatform.Application.DTOs.Course
{
    
    public class AddCourseVideoDto
    {
        public string Title { get; set; }
        public string VideoUrl { get; set; }  
        public int Duration { get; set; }        
        public int Order { get; set; }         
    }

}
