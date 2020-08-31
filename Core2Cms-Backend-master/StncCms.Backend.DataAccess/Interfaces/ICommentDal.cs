using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using StncCms.Backend.Entities.Concrete;

namespace StncCms.Backend.DataAccess.Interfaces
{
    public interface ICommentDal : IGenericDal<Comment>
    {
        Task<List<Comment>> GetAllWithSubCommentsAsync(int blogId, int? parentId);
    }
}
