using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using StncCms.Backend.Entities.Concrete;

namespace StncCms.Backend.Business.Interfaces
{
    public interface ICategoryService : IGenericService<Category>
    {
        Task<List<Category>> GetAllSortedByIdAsync();
        Task<List<Category>> GetAllWithCategoryBlogsAsync();
    }
}
