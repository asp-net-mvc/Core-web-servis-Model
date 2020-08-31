using System;
using System.Collections.Generic;
using System.Text;
using StncCms.Backend.DTO.Interfaces;

namespace StncCms.Backend.DTO.DTOs.AppUserDtos
{
    public class AppUserLoginDto : IDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
