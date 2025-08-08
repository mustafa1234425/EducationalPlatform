using AutoMapper;
using EducationalPlatform.Application.DTOs.Course;
using EducationalPlatform.Application.Features.Courses.Commands.CreateCourse;
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
            CreateMap<AddCourseVideoDto, CourseVideo>();
            CreateMap<CourseVideo, CourseVideoDto>();

        }
    }
}
