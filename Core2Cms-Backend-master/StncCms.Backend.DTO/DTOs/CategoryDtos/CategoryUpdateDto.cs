using System;
using System.Collections.Generic;
using System.Text;
using StncCms.Backend.DTO.Interfaces;

namespace StncCms.Backend.DTO.DTOs.CategoryDtos
{
    public class CategoryUpdateDto : IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
