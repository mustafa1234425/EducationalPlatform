using EducationalPlatform.Application.Features.Courses.Commands.CreateCourse;
using EducationalPlatform.Application.Mapping;
using EducationalPlatform.Infrastructure.DependencyInjection;
using MediatR;
using Microsoft.OpenApi.Models; // ✅ لإضافة Swagger
using Microsoft.AspNetCore.Mvc; // ✅ في حال كنت تستخدم ميزات Mvc متقدمة

var builder = WebApplication.CreateBuilder(args);

// ✅ تسجيل Controllers لتفعيل الـ API
builder.Services.AddControllers();

// ✅ تسجيل Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Educational Platform API",
        Version = "v1"
    });
});

// ✅ تسجيل MediatR
builder.Services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssembly(typeof(CreateCourseCommandHandler).Assembly);
});

// ✅ تسجيل AutoMapper
builder.Services.AddAutoMapper(cfg => { }, typeof(AutoMapperProfile).Assembly);

// ✅ تسجيل الخدمات الخاصة بالـ Infrastructure
builder.Services.AddInfrastructure(builder.Configuration);

var app = builder.Build();

// ✅ إعداد Swagger في البيئة التطويرية
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "Educational Platform API V1");
        options.RoutePrefix = string.Empty; // 👈 لجعل Swagger هو الصفحة الرئيسية
    });
}

app.UseHttpsRedirection();

// ✅ تسجيل الـ Controllers (Endpoints)
app.MapControllers();

app.Run();
