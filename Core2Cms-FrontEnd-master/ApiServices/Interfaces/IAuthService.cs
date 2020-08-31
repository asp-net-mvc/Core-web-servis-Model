using System.Threading.Tasks;
using StncCms.Frontend.Models;

namespace StncCms.Frontend.ApiServices.Interfaces{
    public interface IAuthApiService
    {
        Task<bool> SignIn(AppUserLoginModel model);
    }
}