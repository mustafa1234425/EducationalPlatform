using EducationalPlatform.Domain.Entities;


namespace EducationalPlatform.Application.Interfaces
{
    public interface IBookRepository
    {
        Task AddAsync(Book book);
    }

}
