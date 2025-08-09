using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalPlatform.Application.DTOs.Videos
{
    public class CourseVideoDto
    {
        public int Id { get; set; }      
        public string Title { get; set; } 
        public string VideoUrl { get; set; } 
        public int Order { get; set; }     
        public string Duration { get; set; }
    }

}
