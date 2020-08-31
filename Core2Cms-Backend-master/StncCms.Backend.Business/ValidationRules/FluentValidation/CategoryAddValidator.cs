using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using StncCms.Backend.DTO.DTOs.CategoryDtos;

namespace StncCms.Backend.Business.ValidationRules.FluentValidation
{
    public class CategoryAddValidator : AbstractValidator<CategoryAddDto>
    {
        public CategoryAddValidator()
        {
            RuleFor(I => I.Name).NotEmpty().WithMessage("Ad alanı boş geçilemez");
        }
    }
}
