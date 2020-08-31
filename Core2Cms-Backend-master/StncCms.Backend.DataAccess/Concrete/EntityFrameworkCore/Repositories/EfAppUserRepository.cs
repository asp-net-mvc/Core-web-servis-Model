using System;
using System.Collections.Generic;
using System.Text;
using StncCms.Backend.DataAccess.Interfaces;
using StncCms.Backend.Entities.Concrete;

namespace StncCms.Backend.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfAppUserRepository : EfGenericRepository<AppUser>,IAppUserDal
    {
    }
}
