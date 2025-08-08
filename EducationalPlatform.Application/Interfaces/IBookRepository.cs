using EducationalPlatform.Application.DTOs.Book;
using EducationalPlatform.Domain.Entities;


namespace EducationalPlatform.Application.Interfaces
{
    public interface IBookRepository
    {
        Task AddAsync(Book book);
      

        Task<List<GetBookWithCategoryDto>> GetAllBooksWithCategoryAsync();
    }

}
