using EducationalPlatform.Domain.Common;

namespace EducationalPlatform.Domain.Entities
{
    public class AdminUser : BaseEntity
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string PasswordHash { get; set; }

        public string Role { get; set; }
    }
}
