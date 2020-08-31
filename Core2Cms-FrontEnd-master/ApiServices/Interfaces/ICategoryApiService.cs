using System.Collections.Generic;
using System.Threading.Tasks;
using StncCms.Frontend.Models;

namespace StncCms.Frontend.ApiServices.Interfaces{
    public interface ICategoryApiService
    {
        Task<List<CategoryListModel>> GetAllAsync();
        Task<List<CategoryWithBlogsCountModel>> GetAllWithBlogsCount();

        Task<CategoryListModel> GetByIdAsync(int id);

        Task AddAsync(CategoryAddModel model);

        Task UpdateAsync(CategoryUpdateModel model);
        Task DeleteAsync(int id);
    }
}