using EducationalPlatform.Application.DTOs.AdminLogin;
using EducationalPlatform.Application.Features.Admin.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EducationalPlatform.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AdminController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] AdminLoginDto loginDto)
        {
            var token = await _mediator.Send(new LoginAdminCommand(loginDto));
            return Ok(new { success = true, token });
        }
    }

}
