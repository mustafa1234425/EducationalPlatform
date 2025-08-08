using EducationalPlatform.Application.DTOs.AdminLogin;
using MediatR;


namespace EducationalPlatform.Application.Features.Admin.Commands
{
    public class LoginAdminCommand : IRequest<string>
    {
        public AdminLoginDto LoginDto { get; set; }

        public LoginAdminCommand(AdminLoginDto loginDto)
        {
            LoginDto = loginDto;
        }
    }

}
