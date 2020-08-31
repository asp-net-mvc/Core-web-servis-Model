using System;
using System.Collections.Generic;
using System.Text;
using StncCms.Backend.Entities.Concrete;

namespace StncCms.Backend.Business.Tools.JWTTool
{
    public interface IJwtService
    {
        JwtToken GenerateJwt(AppUser appUser);
    }
}
