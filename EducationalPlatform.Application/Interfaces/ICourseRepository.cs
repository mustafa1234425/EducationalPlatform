using EducationalPlatform.Domain.Entities;

namespace EducationalPlatform.Application.Interfaces
{
    public interface ICourseRepository : IGenericRepository<Course>
    {
        Task<List<Course>> GetAllCoursesWithCategoryAsync();
        Task<List<CourseVideo>> GetVideosByCourseIdAsync(int courseId);
    }


}
