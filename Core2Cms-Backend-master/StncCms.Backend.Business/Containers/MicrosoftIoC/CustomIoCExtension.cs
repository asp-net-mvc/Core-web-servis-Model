using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using StncCms.Backend.Business.Concrete;
using StncCms.Backend.Business.Interfaces;
using StncCms.Backend.Business.Tools.JWTTool;
using StncCms.Backend.Business.Tools.LogTool;
using StncCms.Backend.Business.ValidationRules.FluentValidation;
using StncCms.Backend.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using StncCms.Backend.DataAccess.Interfaces;
using StncCms.Backend.DTO.DTOs.AppUserDtos;
using StncCms.Backend.DTO.DTOs.CategoryBlogDtos;
using StncCms.Backend.DTO.DTOs.CategoryDtos;
using StncCms.Backend.DTO.DTOs.CommentDtos;

namespace StncCms.Backend.Business.Containers.MicrosoftIoC
{
    public static class CustomIoCExtension
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            
            services.AddScoped(typeof(IGenericDal<>), typeof(EfGenericRepository<>));
            services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));

            services.AddScoped<IBlogService, BlogManager>();
            services.AddScoped<IBlogDal, EfBlogRepository>();

            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICategoryDal, EfCategoryRepository>();

            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<IAppUserDal, EfAppUserRepository>();

            services.AddScoped<ICommentService, CommentManager>();
            services.AddScoped<ICommentDal, EfCommentRepository>();

            services.AddScoped<IJwtService, JwtManager>();
            services.AddScoped<ICustomLogger, NLogAdapter>();


            services.AddTransient<IValidator<AppUserLoginDto>, AppUserLoginValidator>();
            services.AddTransient<IValidator<CategoryAddDto>, CategoryAddValidator>();
            services.AddTransient<IValidator<CategoryBlogDto>, CategoryBlogValidator>();
            services.AddTransient<IValidator<CategoryUpdateDto>, CategoryUpdateValidator>();
            services.AddTransient<IValidator<CommentAddDto>, CommentAddValidator>();


        }
    }
}
