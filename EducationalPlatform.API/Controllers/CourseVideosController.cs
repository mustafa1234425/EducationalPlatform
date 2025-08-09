using EducationalPlatform.Application.DTOs.Videos;
using EducationalPlatform.Application.Features.CourseVideos.Commands;
using EducationalPlatform.Application.Features.CourseVideos.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EducationalPlatform.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CourseVideosController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CourseVideosController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateCourseVideoDto dto)
        {
            var id = await _mediator.Send(new CreateCourseVideoCommand { VideoDto = dto });

            return Ok(new { success = true, id });
        }
        [HttpGet("course/{courseId}")]
        public async Task<IActionResult> GetByCourseId(int courseId)
        {
            var videos = await _mediator.Send(new GetVideosByCourseIdQuery { CourseId = courseId });
            return Ok(new { success = true, data = videos });
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateCourseVideoDto dto)
        {
            if (id != dto.Id) return BadRequest("Video ID mismatch");

            var result = await _mediator.Send(new UpdateCourseVideoCommand { VideoDto = dto });
            if (!result) return NotFound(new { success = false, message = "Video not found" });

            return Ok(new { success = true });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _mediator.Send(new DeleteCourseVideoCommand { Id = id });
            if (!result) return NotFound(new { success = false, message = "Video not found" });

            return Ok(new { success = true });
        }


    }

}
