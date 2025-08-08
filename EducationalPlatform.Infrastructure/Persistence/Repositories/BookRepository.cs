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
        public async Task<GetBookWithCategoryDto> GetBookByIdWithCategoryAsync(int id)
        {
#pragma warning disable CS8603 // Possible null reference return.
            return await _context.Books
                .Include(b => b.Category) 
                .Where(b => b.Id == id) 
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
                .FirstOrDefaultAsync(); 
#pragma warning restore CS8603 // Possible null reference return.
        }
        public async Task<bool> UpdateAsync(Book book)
        {
            var existingBook = await _context.Books.FindAsync(book.Id);

            if (existingBook == null)
                return false;

            existingBook.Title = book.Title;
            existingBook.Description = book.Description;
            existingBook.PdfUrl = book.PdfUrl;
            existingBook.ImageUrl = book.ImageUrl;
            existingBook.CategoryId = book.CategoryId;

            await _context.SaveChangesAsync();

            return true;
        }
        public async Task<bool> DeleteAsync(int id)
        {
            var existingBook = await _context.Books.FindAsync(id);

            if (existingBook == null)
                return false;

            _context.Books.Remove(existingBook);

            await _context.SaveChangesAsync();

            return true;
        }


    }


}
