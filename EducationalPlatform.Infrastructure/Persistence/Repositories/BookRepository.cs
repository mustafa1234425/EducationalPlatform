using EducationalPlatform.Application.DTOs.Book;
using EducationalPlatform.Application.Interfaces;
using EducationalPlatform.Domain.Entities;
using EducationalPlatform.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;


namespace EducationalPlatform.Infrastructure.Persistence.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly AppDbContext _context;

        public BookRepository(AppDbContext context)
        {
            _context = context; 
        }

        
        public async Task AddAsync(Book book)
        {
            await _context.Books.AddAsync(book); 
            await _context.SaveChangesAsync();  
        }
        public async Task<List<GetBookWithCategoryDto>> GetAllBooksWithCategoryAsync()
        {
            
            return await _context.Books
                .Include(b => b.Category) 
                .Select(b => new GetBookWithCategoryDto
                {
                    Id = b.Id,
                    Title = b.Title,
                    Description = b.Description,
                    PdfUrl = b.PdfUrl,
                    ImageUrl = b.ImageUrl,
                    CategoryId = b.CategoryId,
                    CategoryName = b.Category.Name
                })
                .ToListAsync();
        }

    }


}
