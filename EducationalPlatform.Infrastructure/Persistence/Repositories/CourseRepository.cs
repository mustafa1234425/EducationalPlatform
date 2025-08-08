using EducationalPlatform.Application.Interfaces;
using EducationalPlatform.Domain.Entities;
using EducationalPlatform.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace EducationalPlatform.Infrastructure.Persistence.Repositories
{
    public class CourseRepository : GenericRepository<Course>, ICourseRepository
    {
        public CourseRepository(AppDbContext context) : base(context)
        {
        }
        public async Task<List<Course>> GetAllCoursesWithCategoryAsync()
        {
            return await _context.Courses
                                 .Include(c => c.Category)
                                 .ToListAsync();
        }

    }
}
