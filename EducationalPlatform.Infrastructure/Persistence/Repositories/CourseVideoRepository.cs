using EducationalPlatform.Application.Interfaces;
using EducationalPlatform.Domain.Entities;
using EducationalPlatform.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;


namespace EducationalPlatform.Infrastructure.Persistence.Repositories
{
    public class CourseVideoRepository : ICourseVideoRepository
    {
        private readonly AppDbContext _context;

        public CourseVideoRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(CourseVideo video)
        {
            await _context.CourseVideos.AddAsync(video); 
            await _context.SaveChangesAsync(); 
        }
        public async Task<List<CourseVideo>> GetByCourseIdAsync(int courseId)
        {
            return await _context.CourseVideos
                                 .Where(v => v.CourseId == courseId)
                                 .OrderBy(v => v.Order) 
                                 .ToListAsync();
        }
        public async Task<CourseVideo> GetByIdAsync(int id)
        {
            return await _context.CourseVideos.FindAsync(id);
        }

        public async Task UpdateAsync(CourseVideo video)
        {
            _context.CourseVideos.Update(video);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(CourseVideo video)
        {
            _context.CourseVideos.Remove(video);
            await _context.SaveChangesAsync();
        }


    }

}
