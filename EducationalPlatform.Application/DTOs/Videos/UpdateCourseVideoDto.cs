

namespace EducationalPlatform.Application.DTOs.Videos
{
    public class UpdateCourseVideoDto
    {
        public int Id { get; set; }          
        public string Title { get; set; }    
        public string VideoUrl { get; set; } 
        public int Order { get; set; }        
        public TimeSpan Duration { get; set; }
    }

}
