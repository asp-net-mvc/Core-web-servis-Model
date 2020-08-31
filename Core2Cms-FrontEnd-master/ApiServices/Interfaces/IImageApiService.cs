using System.Threading.Tasks;

namespace StncCms.Frontend.ApiServices.Interfaces{
    public interface IImageApiService
    {
        Task<string> GetBlogImageByIdAsync(int id);
    }
}