using System.Collections.Generic;
using System.Threading.Tasks;
using StncCms.Backend.Entities.Concrete;

namespace StncCms.Backend.DataAccess.Interfaces
{
    public interface IBlogDal : IGenericDal<Blog>
    {
        Task<List<Blog>> GetAllByCategoryIdAsync(int categoryId);
        Task<List<Category>> GetCategoriesAsync(int blogId);
        Task<List<Blog>> GetLastFiveAsync();
    }
}
