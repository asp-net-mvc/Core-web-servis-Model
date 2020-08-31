using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using StncCms.Backend.DTO.DTOs.AppUserDtos;
using StncCms.Backend.Entities.Concrete;

namespace StncCms.Backend.Business.Interfaces
{
    public interface IAppUserService : IGenericService<AppUser>
    {
        Task<AppUser> CheckUserAsync(AppUserLoginDto appUserLoginDto);
        Task<AppUser> FindByNameAsync(string userName);
    }
}
