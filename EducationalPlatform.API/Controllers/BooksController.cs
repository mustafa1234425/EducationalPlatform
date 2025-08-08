using EducationalPlatform.Application.DTOs.Book;
using EducationalPlatform.Application.Features.Books.Commands;
using EducationalPlatform.Application.Features.Books.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EducationalPlatform.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IMediator _mediator;

       
        public BooksController(IMediator mediator)
        {
            _mediator = mediator;
        }

        
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateBookDto dto)
        {
           
            var id = await _mediator.Send(new CreateBookCommand { BookDto = dto });

            
            return Ok(new { success = true, id });
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var books = await _mediator.Send(new GetAllBooksWithCategoryQuery());

            return Ok(books);
        }

    }

}
