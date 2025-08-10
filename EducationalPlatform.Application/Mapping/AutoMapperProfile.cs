using AutoMapper;
using EducationalPlatform.Application.DTOs.Article;
using EducationalPlatform.Application.DTOs.Category;
using EducationalPlatform.Application.DTOs.Course;
using EducationalPlatform.Application.DTOs.Videos;
using EducationalPlatform.Application.Features.Courses.Commands.CreateCourse;
using EducationalPlatform.Domain.Entities;

namespace EducationalPlatform.Application.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            //CreateMap<CreateCourseDto, Course>();
            CreateMap<Course, CourseDto>()
           .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Name));
            CreateMap<CreateCourseDto, Course>();
            CreateMap<CourseVideo, CourseVideoDto>();
            CreateMap<Article, ArticleDto>()
           .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Name));
            CreateMap<Category, CategoryDto>()
           .ForMember(dest => dest.ParentCategoryName, opt => opt.MapFrom(src => src.ParentCategory != null ? src.ParentCategory.Name : null));
            CreateMap<CreateCategoryDto, Category>();
            CreateMap<UpdateCategoryDto, Category>();


        }
    }
}
