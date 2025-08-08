using EducationalPlatform.Domain.Entities;


namespace EducationalPlatform.Application.Interfaces
{
    public interface IJwtTokenService
    {
        string GenerateToken(AdminUser admin);
    }

}
