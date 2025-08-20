# EducationalPlatform
# 📚 Professional Educational Platform - Backend API

> **Note**: This project is **Work In Progress (WIP)**. Some features are not yet complete and may change during development.

## 👋 Overview
**Professional Educational Platform** is a full-featured system designed to provide users with:  
- Interactive Courses  
- Educational Books  
- Specialized Articles  
- Exercises and Assessments  
- Latest Educational News  

The project includes an **Admin Dashboard** to manage all content securely using **JWT Authentication**.  
It is designed to be **scalable** and flexible to support future features such as subscriptions, paid courses, and ratings.

---

## 🏗️ Clean Architecture
The solution is built with **ASP.NET Core 8 + EF Core 8 + SQL Server** using **Clean Architecture** principles for scalability and maintainability:

EducationalPlatform.API → Web API entry point
EducationalPlatform.Application → Use Cases (DTOs, Commands, Queries, Handlers)
EducationalPlatform.Domain → Core Entities (Domain Models)
EducationalPlatform.Infrastructure → Data Access Layer (Repositories, EF Core)

markdown
Copy
Edit

---

## ✨ Main Features

### Public API
- Home page showcasing:
  - Platform introduction  
  - Featured courses  
  - Latest articles  
- Browse content by specialization (e.g., Programming, Design, AI)  
- Detailed pages for courses, books, and articles  
- Downloadable books in PDF format  

### Admin API
- Admin login with JWT Authentication  
- Course management:
  - Add / Update / Delete courses  
  - Upload images and assign categories  
- Course video management:
  - Upload video or add YouTube/Vimeo link  
  - Define ordering inside courses  
- Book management:
  - Upload PDFs and cover images  
- Article management:
  - Full HTML content support  
  - Assign categories and tags  
- Category and specialization management  
- User management (future feature)  

---

## 🛠️ Current Progress

### 1. Base Solution Structure
- Created the four core projects (API / Application / Domain / Infrastructure)  
- Configured EF Core with SQL Server  
- Generated the initial migration:
  ```bash
  Add-Migration InitialCreate
  Update-Database
2. Domain Entities
Course

CourseVideo

Book

Article

Category

AdminUser

Tag

CourseTag (many-to-many relationship)

3. Repository Layer
IGenericRepository<T>

ICourseRepository

GenericRepository<T>

CourseRepository

Registered in Dependency Injection:

csharp
Copy
Edit
services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
services.AddScoped<ICourseRepository, CourseRepository>();
4. Use Case: Create Course
CreateCourseDto

CreateCourseCommand + Handler

AutoMapperProfile

Integrated MediatR and AutoMapper in Program.cs

Implemented CoursesController → POST /api/courses

5. API Testing
Successfully added a new course into the database

Verified the endpoint works as expected

Standardized API response format

🚀 Technologies Used
ASP.NET Core 8 Web API

Entity Framework Core 8 (Code First)

SQL Server

Clean Architecture

Repository Pattern

MediatR (CQRS Pattern)

AutoMapper

JWT Authentication

Swagger API Documentation
