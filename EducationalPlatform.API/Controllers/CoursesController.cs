using EducationalPlatform.API.Responses;
using EducationalPlatform.Application.DTOs.Course;
using EducationalPlatform.Application.Features.Courses.Commands.CreateCourse;
using EducationalPlatform.Application.Features.Courses.Queries.GetAllCourses;
using EducationalPlatform.Application.Features.Courses.Queries.GetVideosByCourseId;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EducationalPlatform.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CoursesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CoursesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateCourseDto dto)
        {
            var command = new CreateCourseCommand(dto);
            var id = await _mediator.Send(command);

            return Ok(new { CourseId = id });
        }
        [HttpGet]
        public async Task<IActionResult> GetAllCourses()
        {
            var result = await _mediator.Send(new GetAllCoursesQuery());
            return Ok(new ApiResponse<List<CourseDto>>(result));
        }
        
        [HttpPost("{courseId}/videos")]
        public async Task<IActionResult> AddVideoToCourse(int courseId, [FromBody] AddCourseVideoDto dto)
        {
            
            var command = new AddCourseVideoCommand(courseId, dto);

           
            var result = await _mediator.Send(command);

           
            return Ok(new { success = true, videoId = result });
        }
        
        [HttpGet("{courseId}/videos")]
        public async Task<IActionResult> GetVideosByCourseId(int courseId)
        {
            
            var query = new GetVideosByCourseIdQuery(courseId);

            
            var videos = await _mediator.Send(query);

           
            return Ok(new { success = true, data = videos });
        }

    }
}
