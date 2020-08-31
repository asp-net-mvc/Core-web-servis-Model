using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StncCms.Backend.Business.Interfaces;
using StncCms.Backend.DataAccess.Concrete.EntityFrameworkCore.Context;
using StncCms.Backend.DataAccess.Interfaces;
using StncCms.Backend.DTO.DTOs.BlogDtos;
using StncCms.Backend.DTO.DTOs.CategoryBlogDtos;
using StncCms.Backend.Entities.Concrete;

namespace StncCms.Backend.Business.Concrete
{
    public class BlogManager : GenericManager<Blog>,IBlogService
    {
        private readonly IGenericDal<Blog> _genericDal;
        private readonly IGenericDal<CategoryBlog> _categoryBlogService;
        private readonly IBlogDal _blogDal;
        public BlogManager(IGenericDal<Blog> genericDal, IGenericDal<CategoryBlog> categoryBlogService,IBlogDal blogDal) : base(genericDal)
        {
            _blogDal = blogDal;
            _categoryBlogService = categoryBlogService;
            _genericDal = genericDal;
        }

        public async Task<List<Blog>> GetAllSortedByPostedTimeAsync()
        {
            /*
            //burada expression func tanıomla ile ilgili bir ornek hazırladım 

            Expression<Func<Blog, bool>> filter = I => true;
            Expression<Func<Blog, object>> filter2 = I => I.Id;

            //using var context = new CMSBlogContext();
            //return await context.Blogs.OrderByDescending(I => I.PostedTime).Take(5).ToListAsync();

            */

            return await _genericDal.GetAllAsync(I => true, I => I.Title) ;



        }

        public async Task AddToCategoryAsync(CategoryBlogDto categoryBlogDto)
        {
            var control = await _categoryBlogService.GetAsync(I => I.CategoryId == categoryBlogDto.CategoryId && I.BlogId == categoryBlogDto.BlogId);
            if (control == null)
            {
                await _categoryBlogService.AddAsync(new CategoryBlog
                {
                    BlogId = categoryBlogDto.BlogId,
                    CategoryId = categoryBlogDto.CategoryId
                });
            }
           
        }
        public async Task RemoveFromCategoryAsync(CategoryBlogDto categoryBlogDto)
        {
           var deletedCategoryBlog=  await  _categoryBlogService.GetAsync(I => I.CategoryId == categoryBlogDto.CategoryId && I.BlogId == categoryBlogDto.BlogId);
            if (deletedCategoryBlog != null)
            {
                await _categoryBlogService.RemoveAsync(deletedCategoryBlog);
            }
          
           
        }

        public async Task<List<Blog>> GetAllByCategoryIdAsync(int categoryId)
        {
            return await _blogDal.GetAllByCategoryIdAsync(categoryId);
        }

        public async Task<List<Category>> GetCategoriesAsync(int blogId)
        {
            return await _blogDal.GetCategoriesAsync(blogId);
        }

        public async Task<List<Blog>> GetLastFiveAsync()
        {
            return await _blogDal.GetLastFiveAsync();
        }

        public async Task<List<Blog>> SearchAsync(string searchString)
        {
           return await _blogDal.GetAllAsync(I => I.Title.Contains(searchString) || I.ShortDescription.Contains(searchString) || I.Description.Contains(searchString), I => I.PostedTime);
        }
    }
}
