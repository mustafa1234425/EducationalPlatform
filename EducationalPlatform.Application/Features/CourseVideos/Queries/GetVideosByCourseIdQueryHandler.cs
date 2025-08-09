using AutoMapper;
using EducationalPlatform.Application.DTOs.Videos;
using EducationalPlatform.Application.Interfaces;
using MediatR;


namespace EducationalPlatform.Application.Features.CourseVideos.Queries
{
    public class GetVideosByCourseIdQueryHandler
    : IRequestHandler<GetVideosByCourseIdQuery, List<CourseVideoDto>>
    {
        private readonly ICourseVideoRepository _repository;
        private readonly IMapper _mapper;

        public GetVideosByCourseIdQueryHandler(ICourseVideoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<CourseVideoDto>> Handle(GetVideosByCourseIdQuery request, CancellationToken cancellationToken)
        {
            var videos = await _repository.GetByCourseIdAsync(request.CourseId);

            return _mapper.Map<List<CourseVideoDto>>(videos);
        }
    }

}
