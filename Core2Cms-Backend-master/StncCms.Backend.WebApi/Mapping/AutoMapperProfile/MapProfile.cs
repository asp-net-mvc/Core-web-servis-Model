using AutoMapper;
using StncCms.Backend.DTO.DTOs.BlogDtos;
using StncCms.Backend.DTO.DTOs.CategoryDtos;
using StncCms.Backend.DTO.DTOs.CommentDtos;
using StncCms.Backend.Entities.Concrete;
using StncCms.Backend.WebApi.Models;

namespace StncCms.Backend.WebApi.Mapping.AutoMapperProfile
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<BlogListDto, Blog>();
            CreateMap<Blog, BlogListDto>();

            CreateMap<BlogUpdateModel, Blog>();
            CreateMap<Blog, BlogUpdateModel>();

            CreateMap<BlogAddModel, Blog>();
            CreateMap<Blog, BlogAddModel>();

            CreateMap<CategoryAddDto, Category>();
            CreateMap<Category, CategoryAddDto>();

            CreateMap<CategoryListDto, Category>();
            CreateMap<Category, CategoryListDto>();

            CreateMap<CategoryUpdateDto, Category>();
            CreateMap<Category, CategoryUpdateDto>();


            CreateMap<Comment, CommentListDto>();
            CreateMap<CommentListDto, Comment>();

            CreateMap<Comment, CommentAddDto>();
            CreateMap<CommentAddDto, Comment>();
        }
    }
}
