using StncCms.Backend.Business.Interfaces;
using StncCms.Backend.DataAccess.Interfaces;
using StncCms.Backend.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StncCms.Backend.Business.Concrete
{
    public class CommentManager : GenericManager<Comment>, ICommentService
    {
        private readonly ICommentDal _commentDal;

        public CommentManager(IGenericDal<Comment> genericDal, ICommentDal commentDal) : base(genericDal)
        {
            _commentDal = commentDal;
        }

        public Task<List<Comment>> GetAllWithSubCommentsAsync(int blogId, int? parentId)
        {
            return _commentDal.GetAllWithSubCommentsAsync(blogId, parentId);
        }
    }
}