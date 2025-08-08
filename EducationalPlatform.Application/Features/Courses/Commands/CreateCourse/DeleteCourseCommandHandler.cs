using EducationalPlatform.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalPlatform.Application.Features.Courses.Commands.CreateCourse
{
    public class DeleteCourseCommandHandler : IRequestHandler<DeleteCourseCommand, bool>
    {
        private readonly ICourseRepository _repository; 

       
        public DeleteCourseCommandHandler(ICourseRepository repository)
        {
            _repository = repository; 
        }

        
        public async Task<bool> Handle(DeleteCourseCommand request, CancellationToken cancellationToken)
        {
            var course = await _repository.GetByIdAsync(request.Id);

            if (course == null)
                return false;

            await _repository.DeleteAsync(course);

            return true;
        }
    }

}
