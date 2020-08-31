using System.ComponentModel.DataAnnotations;

namespace StncCms.Frontend.Models{
    public class CategoryAddModel{
        [Required(ErrorMessage="Ad alanı gereklidir")]
        [Display(Name="Ad :")]
        public string Name { get; set; }
    }
}