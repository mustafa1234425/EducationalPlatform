using EducationalPlatform.Domain.Entities;


namespace EducationalPlatform.Application.Interfaces
{
    public interface IArticleRepository
    {
        Task AddAsync(Article article);
        Task<List<Article>> GetAllWithCategoryAsync();
        Task<Article> GetByIdAsync(int id);
        Task UpdateAsync(Article article);
        Task DeleteAsync(Article article);
    }

}
