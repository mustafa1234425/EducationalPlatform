
using System.Threading.Tasks;

namespace EducationalPlatform.Application.DTOs.Book
{
    public class UpdateBookDto
    {
        public int Id { get; set; }
        public string Title { get; set; } 
        public string Description { get; set; } 
        public string PdfUrl { get; set; }
        public string ImageUrl { get; set; } 
        public int CategoryId { get; set; }
    }

}
