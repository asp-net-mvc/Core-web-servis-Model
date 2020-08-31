using System.Collections.Generic;
using System.Threading.Tasks;
using StncCms.Backend.Entities.Concrete;

namespace StncCms.Backend.Business.Interfaces
{
    public interface ICommentService : IGenericService<Comment>
    {
        Task<List<Comment>> GetAllWithSubCommentsAsync(int blogId, int? parentId);
    }
}
