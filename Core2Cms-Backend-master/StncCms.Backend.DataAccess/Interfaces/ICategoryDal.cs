using System.Collections.Generic;
using System.Threading.Tasks;
using StncCms.Backend.Entities.Concrete;

namespace StncCms.Backend.DataAccess.Interfaces
{
    public interface ICategoryDal : IGenericDal<Category>
    {
        Task<List<Category>> GetAllWithCategoryBlogsAsync();
    }
}
