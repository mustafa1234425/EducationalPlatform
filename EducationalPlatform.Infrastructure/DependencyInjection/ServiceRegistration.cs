using EducationalPlatform.Application.Interfaces;
using EducationalPlatform.Infrastructure.Persistence.Context;
using EducationalPlatform.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EducationalPlatform.Infrastructure.DependencyInjection
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            // تسجيل الـ Repositories
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<ICourseRepository, CourseRepository>();
            //services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<ICourseVideoRepository, CourseVideoRepository>();



            return services;
        }
    }
}
