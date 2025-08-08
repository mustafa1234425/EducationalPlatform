using AutoMapper;
using EducationalPlatform.Application.DTOs.Course;
using EducationalPlatform.Domain.Entities;

namespace EducationalPlatform.Application.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CreateCourseDto, Course>();
            CreateMap<Course, CourseDto>()
           .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Name));
            CreateMap<CreateCourseDto, Course>();

        }
    }
}
