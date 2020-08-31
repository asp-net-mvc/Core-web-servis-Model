using System;
using System.Collections.Generic;
using System.Text;
using StncCms.Backend.DTO.Interfaces;

namespace StncCms.Backend.DTO.DTOs.CategoryDtos
{
    public class CategoryAddDto : IDto
    {
        public string Name { get; set; }
    }
}
