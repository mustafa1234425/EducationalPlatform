using EducationalPlatform.Domain.Entities;


namespace EducationalPlatform.Application.Interfaces
{
    public interface ICourseVideoRepository
    {
        Task AddAsync(CourseVideo video);
        Task<List<CourseVideo>> GetByCourseIdAsync(int courseId); 
        Task<CourseVideo> GetByIdAsync(int id); 
        Task UpdateAsync(CourseVideo video);  
        Task DeleteAsync(CourseVideo video); 
    }

}
