using EducationalPlatform.Application.Interfaces;
using EducationalPlatform.Domain.Entities;
using MediatR;
using BCrypt.Net;

namespace EducationalPlatform.Application.Features.Admin.Commands
{
    public class LoginAdminCommandHandler : IRequestHandler<LoginAdminCommand, string>
    {
        private readonly IGenericRepository<AdminUser> _adminRepo;
        private readonly IJwtTokenService _jwtService;

        public LoginAdminCommandHandler(IGenericRepository<AdminUser> adminRepo, IJwtTokenService jwtService)
        {
            _adminRepo = adminRepo;
            _jwtService = jwtService;
        }

        public async Task<string> Handle(LoginAdminCommand request, CancellationToken cancellationToken)
        {
            
            var admin = (await _adminRepo.GetAllAsync())
                .FirstOrDefault(a => a.Email == request.LoginDto.Email);

            if (admin == null)
                throw new Exception("Invalid email or password");

            
            if (!BCrypt.Net.BCrypt.Verify(request.LoginDto.Password, admin.PasswordHash))
                throw new Exception("Invalid email or password");

           
            return _jwtService.GenerateToken(admin);
        }
    }

}
