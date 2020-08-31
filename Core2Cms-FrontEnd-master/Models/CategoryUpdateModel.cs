using System.ComponentModel.DataAnnotations;

namespace StncCms.Frontend.Models{
    public class CategoryUpdateModel{
        public int Id { get; set; }
        [Required(ErrorMessage="Ad alanı boş geçilemez")]
        [Display(Name="Ad :")]
        public string Name { get; set; }
    }
}