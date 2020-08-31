using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StncCms.Backend.DataAccess.Concrete.EntityFrameworkCore.Context;
using StncCms.Backend.DataAccess.Interfaces;
using StncCms.Backend.Entities.Concrete;

namespace StncCms.Backend.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfCategoryRepository : EfGenericRepository<Category>, ICategoryDal
    {
        public async Task<List<Category>> GetAllWithCategoryBlogsAsync()
        {
            using var context = new MyBlogContext();
            return await context.Categories.OrderByDescending(I=>I.Id).Include(I => I.CategoryBlogs).ToListAsync();
        }
    }
}
